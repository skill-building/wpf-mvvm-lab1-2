# WPF MVVM Lab 1.2

A WPF application demonstrating the **MVVM** pattern with full CRUD operations (Create, Read, Update, Delete) on employee role data.

## Features

- Main window with **Employees** and **Roles** menus
- Employee list displays role *names* (Director, Accountant, Manager) instead of role IDs
- **Roles module** — full CRUD:
  - Add a new role
  - Edit an existing role
  - Delete a role (with confirmation dialog)
- Add / Edit / Delete buttons automatically enable or disable based on selection
- Live UI updates via `INotifyPropertyChanged`

## Structure

| Folder | Contents |
|--------|----------|
| `Model/` | `Person`, `Role`, `PersonDPO` — domain classes with `INotifyPropertyChanged` |
| `ViewModel/` | `PersonViewModel`, `RoleViewModel` — data + commands |
| `View/` | `WindowEmployee`, `WindowRole`, `WindowNewRole` — XAML windows |
| `Helper/` | `FindRole`, `RelayCommand` — predicate and command pattern |

## MVVM Key Concepts Implemented

- **Data binding** — `{Binding ListRole}`, `{Binding SelectedRole}`
- **`INotifyPropertyChanged`** — automatic UI refresh on property change
- **`ICommand` / `RelayCommand`** — buttons bound to ViewModel commands, no event handlers in code-behind
- **`ObservableCollection`** — automatic list updates on add/remove
- **`CanExecute`** — buttons disable when no row is selected
- **Dialog windows** — `WindowNewRole` for add/edit with `ShowDialog()` and `DialogResult`

## Run

Open `MVVM1.slnx` in Visual Studio 2022 (17.13+) and press **F5**.

## Tech

- C# / .NET 8
- WPF (`ListView` + `GridView`, data binding)
- MVVM pattern
