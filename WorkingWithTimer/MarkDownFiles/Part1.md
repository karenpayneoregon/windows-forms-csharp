# GitHub Flavored Markdown Spec

https://github.github.com/gfm/


# Basic writing and formatting syntax

<!-- This content will not appear in the rendered Markdown -->

```mermaid
graph TD;
    A-->B;
    A-->C;
    B-->D;
    C-->D;
```

Above is a header level 1

```markdown
# Basic writing and formatting syntax
```

## Level II

Above is level 2

```markdown
## Level II
```

## Level III

Above is level III

```markdown
## Level III
```

Levels use <kbd>#</kbd> as the symbol to create a header as per above.

---

To show keyboard <kbd>CTRL</kbd> + <kbd>C</kbd> combinations

```markdown
<kbd>CTRL</kbd> + <kbd>C</kbd>
```

---

# Text

**bold**

```markdown
**bold**
```

*italics*

```markdown
*italics*
```

~~This was mistaken text~~

```markdown
~~This was mistaken text~~
```

Karen said

> C# is a great programming language

```markdown
> C# is a great programming language
```

**Quoting** code: Use `git status` to list all new or modified files that haven't yet been committed.

```markdown
Use `git status` to list all new
```

**Links**

This site was built using [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

```markdown
This site was built using [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).
```

# Images

**Note** that the following will display differently in Visual Studio and Visual Code which means bes to size the image rather than use width and height as per below.

Generally the image is inserted using



```markdown
![GrrrImage](assets/Grrrrr.png)
```

![GrrrImage](assets/Grrrrr.png)

In some cases you can control the image size using `{ width=10% height=20% }
`

![foo](assets/Grrrrr.png){ width=10% height=20% }



# Symbols

← → ↑ ↓ </br>
↔ ↕ </br>
↖ ↗ ↘ ↙ </br>
⤡ ⤢ </br>
↚ ↛ ↮  </br>
⟵ ⟶ ⟷ </br>
⇦ ⇨ ⇧ ⇩ </br>
⬄ ⇳ </br>
⬁ ⬀ ⬂ ⬃ </br>
⬅ ⮕ ➡ ⬆ ⬇ </br>
⬉ ⬈ ⬊ ⬋ </br>
⬌ ⬍ </br>
🡐 🡒 🡑 🡓 </br>
🡔 🡕 🡖 🡗 </br>
🡘 🡙 </br>
⭠ ⭢ ⭡ ⭣ </br>
⭤ ⭥ </br>
⭦ ⭧ ⭨ ⭩ </br>
🠀 🠂 🠁 🠃 </br>
🠄 🠆 🠅 🠇 </br>
🠈 🠊 🠉 🠋 </br>
🠠 🠢 🠡 🠣 </br>
🠤 🠦 🠥 🠧 </br>
🠨 🠪 🠩 🠫 </br>
🠬 🠮 🠭 🠯 </br>
🠰 🠲 🠱 🠳 </br>

&#8592; &nbsp; &#8594;

&#8593;&nbsp; &#8595;

---

