using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2.Classes
{
    public class MockedData
    {
        public static List<BoxItem> Boxes()
        {
            return new List<BoxItem>()
            {
                new BoxItem() {Length = 25, Unit = Unit.IM},
                new BoxItem() {Length = 26, Unit = Unit.IM},
                new BoxItem() {Length = 27, Unit = Unit.IM}
            };
        }
    }
}
