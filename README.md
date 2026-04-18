# 📒 Note Taking Application (C# WinForms)

## 📌 Overview

The **Note Taking Application** is a simple Windows Forms desktop application built using **C# (.NET WinForms)**. It allows users to create, view, read, and delete notes using a graphical interface.

The application uses an in-memory **DataTable** to store notes during runtime.

---

## 🚀 Features

* ➕ Add new notes with a title and description
* 📋 Display notes in a DataGridView
* 👁️ Read/view selected note details
* 🗑️ Delete selected notes
* ✏️ Basic edit functionality (via second form)

---

## 🛠️ Technologies Used

* Language: C#
* Framework: .NET Windows Forms
* UI Components:

  * TextBox (for Title and Note input)
  * DataGridView (for displaying notes)
  * Buttons (Add, Delete, Read, Edit)
* Data Storage: `System.Data.DataTable`

---

## 📊 Data Model

The application uses a DataTable with the following structure:

| Column | Type   | Description       |
| ------ | ------ | ----------------- |
| Title  | string | Note title        |
| Note   | string | Note content/body |

---

## ⚙️ How It Works

### ➕ Add Note

* Enter title and note
* Click **Add**
* Data is stored in DataTable and displayed in grid

### 👁️ Read Note

* Select a row
* Click **Read**
* Note details appear in a MessageBox

### 🗑️ Delete Note

* Select a row
* Click **Delete**
* Selected note is removed

### ✏️ Edit Note

* Select a note
* Open edit form
* Modify values and confirm update

---

## ⚠️ Known Issues

* Edit functionality does not properly update existing rows (uses new Form1 instance)
* No null-checking for selected rows in some operations
* Data is not persistent (lost when app closes)

---

## 🔧 Future Improvements

* Fix edit functionality (update selected row instead of adding new)
* Add file/database persistence (SQL or JSON storage)
* Improve validation and error handling
* Implement proper OOP design using a Note class

---

## 📚 Learning Purpose

This project is ideal for learning:

* Windows Forms development
* Event-driven programming
* Basic CRUD operations
* Data binding with DataGridView

---

## 👨‍💻 Author

Sayed Muhammad Ali Shah
Developed as a practice project for learning C# WinForms development.
