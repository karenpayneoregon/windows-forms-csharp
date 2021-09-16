using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ListBoxDisableApp
{
    /// <summary>
    /// Taken from  https://stackoverflow.com/questions/17090317/how-to-disable-selected-item-in-list-box
    /// Modified by Karen Payne
    /// </summary>
    public class ListBoxEx : ListBox
    {
        public event EventHandler<IndexEventArgs> DisabledItemSelected;
        protected virtual void OnDisabledItemSelected(object sender, IndexEventArgs e)
        {
            if (DisabledItemSelected != null)
            {
                DisabledItemSelected(sender, e);
            }
        }
        public ListBoxEx()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            _disabledIndices = new DisabledIndexCollection(this);
        }

        private int _originalHeight = 0;
        private bool _fontChanged = false;

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            _fontChanged = true;
            ItemHeight = FontHeight;
            Height = GetPreferredHeight();
            _fontChanged = false;

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (!_fontChanged)
            {
                _originalHeight = Height;
            }
        }

        public void DisableItem(int index)
        {
            _disabledIndices.Add(index);
        }

        public void EnableItem(int index)
        {
            _disabledIndices.Remove(index);
        }

        private int GetPreferredHeight()
        {
            if (!IntegralHeight)
            {
                return Height;
            }

            int currentHeight = this._originalHeight;
            int preferredHeight = PreferredHeight;
            if (currentHeight < preferredHeight)
            {
                // Calculate how many items currentheigh can hold.
                int number = currentHeight / ItemHeight;

                if (number < Items.Count)
                {
                    preferredHeight = number * ItemHeight;
                    int delta = currentHeight - preferredHeight;

                    if (ItemHeight / 2 <= delta)
                    {
                        preferredHeight += ItemHeight;
                    }

                    preferredHeight += (SystemInformation.BorderSize.Height * 4) + 3;

                }
                else
                {
                    preferredHeight = currentHeight;
                }
            }
            else
                preferredHeight = currentHeight;

            return preferredHeight;

        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            int currentSelectedIndex = SelectedIndex;
            List<int> selectedDisabledIndices = new List<int>();

            for (int i = 0; i < SelectedIndices.Count; i++)
            {
                if (_disabledIndices.Contains(SelectedIndices[i]))
                {
                    selectedDisabledIndices.Add(SelectedIndices[i]);
                    SelectedIndices.Remove(SelectedIndices[i]);
                }
            }
            foreach (int index in selectedDisabledIndices)
            {
                IndexEventArgs args = new IndexEventArgs(index);
                OnDisabledItemSelected(this, args);
            }

            if (currentSelectedIndex == SelectedIndex)
                base.OnSelectedIndexChanged(e);
        }

        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (DesignMode && Items.Count == 0)
            {
                return;
            }

            if (e.Index != ListBox.NoMatches)
            {
                object item = this.Items[e.Index];

                if (_disabledIndices.Contains(e.Index))
                {
                    e.Graphics.FillRectangle(SystemBrushes.InactiveBorder, e.Bounds);

                    if (item != null)
                    {
                        e.Graphics.DrawString(item.ToString(), e.Font, SystemBrushes.GrayText, e.Bounds);
                    }
                }
                else
                {
                    if (SelectionMode == System.Windows.Forms.SelectionMode.None)
                    {
                        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

                        if (item != null)
                        {
                            e.Graphics.DrawString(item.ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
                        }
                    }
                    else
                    {
                        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        {
                            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                            e.DrawFocusRectangle();
                            if (item != null)
                            {
                                e.Graphics.DrawString(item.ToString(), e.Font, SystemBrushes.HighlightText, e.Bounds);
                            }
                        }
                        else
                        {
                            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                            if (item != null)
                            {
                                e.Graphics.DrawString(item.ToString(), e.Font, SystemBrushes.WindowText, e.Bounds);
                            }
                        }
                    }
                }
            }
        }

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private DisabledIndexCollection _disabledIndices;

        public DisabledIndexCollection DisabledIndices => _disabledIndices;

        public class DisabledIndexCollection : IList, ICollection, IEnumerable
        {
            // Fields
            // ReSharper disable once FieldCanBeMadeReadOnly.Local
            private ListBox _owner;

            // ReSharper disable once FieldCanBeMadeReadOnly.Local
            private List<int> _innerList = new List<int>();


            // Methods
            public DisabledIndexCollection(ListBox owner)
            {
                _owner = owner;
            }

            public void Add(int index)
            {
                if (((_owner != null) && (_owner.Items != null)) && ((index != -1) && !Contains(index)))
                {
                    _innerList.Add(index);
                    _owner.SetSelected(index, false);
                }
            }

            public void Clear()
            {
                if (_owner != null)
                {
                    _innerList.Clear();
                }
            }

            public bool Contains(int selectedIndex)
            {
                return (IndexOf(selectedIndex) != -1);
            }

            public void CopyTo(Array destination, int index)
            {
                int count = Count;

                for (int indexer = 0; indexer < count; indexer++)
                {
                    destination.SetValue(this[indexer], (int)(indexer + index));
                }
            }

            public IEnumerator GetEnumerator()
            {
                return new SelectedIndexEnumerator(this);
            }

            public int IndexOf(int selectedIndex)
            {
                if ((selectedIndex >= 0) && (selectedIndex < this._owner.Items.Count))
                {
                    for (int index = 0; index < _innerList.Count; index++)
                    {
                        if (_innerList[index] == selectedIndex)
                            return index;
                    }
                }
                return -1;
            }

            public void Remove(int index)
            {
                if (((_owner != null) && (_owner.Items != null)) && ((index != -1) && Contains(index)))
                {
                    _innerList.Remove(index);
                    _owner.SetSelected(index, false);
                }
            }

            int IList.Add(object value)
            {
                throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            void IList.Clear()
            {
                throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            bool IList.Contains(object selectedIndex)
            {
                return ((selectedIndex is int) && Contains((int)selectedIndex));
            }

            int IList.IndexOf(object selectedIndex)
            {
                if (selectedIndex is int)
                {
                    return IndexOf((int)selectedIndex);
                }
                return -1;
            }

            void IList.Insert(int index, object value)
            {
                throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            void IList.Remove(object value)
            {
                throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            void IList.RemoveAt(int index)
            {
                throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            // Properties
            [Browsable(false)]
            public int Count => _innerList.Count;

            public bool IsReadOnly => true;

            public int this[int index] => IndexOf(index);

            bool ICollection.IsSynchronized => true;

            object ICollection.SyncRoot => this;

            bool IList.IsFixedSize => true;

            object IList.this[int index]
            {
                get => this[index];
                set => throw new NotSupportedException("ListBoxSelectedIndexCollectionIsReadOnly");
            }

            // Nested Types
            private class SelectedIndexEnumerator : IEnumerator
            {
                // Fields
                private int _current;
                private ListBoxEx.DisabledIndexCollection _items;

                // Methods
                public SelectedIndexEnumerator(DisabledIndexCollection items)
                {
                    this._items = items;
                    _current = -1;
                }

                bool IEnumerator.MoveNext()
                {
                    if (_current < (_items.Count - 1))
                    {
                        _current++;
                        return true;
                    }
                    _current = _items.Count;
                    return false;
                }

                void IEnumerator.Reset()
                {
                    _current = -1;
                }

                // Properties
                object IEnumerator.Current
                {
                    get
                    {
                        if ((_current == -1) || (this._current == _items.Count))
                        {
                            throw new InvalidOperationException("ListEnumCurrentOutOfRange");
                        }
                        return this._items[_current];
                    }
                }
            }
        }

        public new void SetSelected(int index, bool value)
        {
            int num = (Items == null) ? 0 : Items.Count;

            if ((index < 0) || (index >= num))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (SelectionMode == SelectionMode.None)
            {
                throw new InvalidOperationException("ListBoxInvalidSelectionMode");
            }

            if (!_disabledIndices.Contains(index))
            {
                if (!value)
                {
                    if (SelectedIndices.Contains(index))
                        SelectedIndices.Remove(index);
                }
                else
                {
                    base.SetSelected(index, value);
                }
            }

            // Selected index does not change, however we should redraw the disabled item.
            else
            {
                if (!value)
                {
                    // Remove selected item if it is in the list of selected indices.
                    if (SelectedIndices.Contains(index))
                    {
                        SelectedIndices.Remove(index);
                    }
                }

            }
            Invalidate(GetItemRectangle(index));
        }
    }

    public class IndexEventArgs : EventArgs
    {
        private int _index;
        public int Index
        {
            get => _index;

            set => _index = value;
        }
        public IndexEventArgs(int index)
        {
            Index = index;
        }
    }
}

