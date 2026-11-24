# Parcial #3 (práctica) + Laboratorio de MVP — Herramientas de la Programación Aplicada III (.NET)

**Universidad Tecnológica de Panamá** · Facultad de Ingeniería en Sistemas Computacionales · Campus Víctor Levi Sasso

| | |
| --- | --- |
| **Autor** | Christian Arce |
| **Grupo** | 1IL133 |
| **Instructora** | Ing. Irina Fong |
| **Fecha** | 24 de noviembre de 2026 |

---

## Contenido

Todo se abre junto con **`Parcial_3.slnx`**.

| Carpeta | Qué contiene | Cumple |
| --- | --- | --- |
| `Punto1_Figuras/` | Clase abstracta `Figura`, clases `Rectangulo`, `Cuadrado`, `Triangulo`, arreglo `Figura[]` y recorrido polimórfico (consola) | Parcial 3, punto 1 |
| `Punto2_Json/` | Serialización de un objeto a JSON con Newtonsoft.Json (consola) | Parcial 3, punto 2 |
| `Punto3_LoginBCrypt/` | **Aplicación de Windows Forms** con login BCrypt, arquitectura de 4 capas y patrón MVP: menú lateral, hora actual y usuario de la sesión | Parcial 3, punto 3 **y** Laboratorio de MVP |
| `BaseDeDatos/` | Scripts de MySQL y el backup `LoginBCryptDB_backup.sql` | Ambos |
| `images/` | Capturas de pantalla de los resultados | README |

---

## Tecnologías y versiones

| Tecnología | Versión | Uso |
| --- | --- | --- |
| C# / .NET | .NET 10 (`net10.0` y `net10.0-windows`) | Todos los proyectos |
| Windows Forms | .NET 10 | Interfaz gráfica del punto 3 |
| Visual Studio | 2026 Insiders | IDE (carga de trabajo "Desarrollo de escritorio de .NET") |
| BCrypt.Net-Next | 4.0.3 | Generar y verificar hashes de contraseñas |
| MySql.Data (Connector/NET) | 9.7.0 | Conexión a MySQL |
| Newtonsoft.Json | 13.0.3 | Punto 2: convertir objetos a JSON |
| MySQL Server | 8.0 | Base de datos `LoginBCryptDB` |
| MySQL Workbench | 8.0 | Ejecutar los scripts y hacer el backup |

---

## Punto 3 — Aplicación de login (Parcial 3 + Laboratorio de MVP)

### Arquitectura por capas

Cada capa es un proyecto separado. Las flechas indican "conoce a":

```text
Presentacion (Windows Forms + MVP)
      │
      ▼
   Negocio  ──► IHashService, IVerificarHashService, BcryptPasswordService
      │
      ▼
    Datos   ──► MySQL (usuario app_login, privilegios mínimos)

Entidades: la usan todas las capas (Usuario, IntentoLogin, ResumenAccesos)
```

| Capa | Proyecto | Responsabilidad |
| --- | --- | --- |
| Entidades | `Entidades/` | Clases puras con los datos: `Usuario`, `IntentoLogin`, `ResumenAccesos` |
| Datos | `Datos/` | Conexión a MySQL y consultas con parámetros: `Conexion`, `UsuarioRepositorio`, `IntentoLoginRepositorio` |
| Negocio | `Negocio/` | Los dos contratos de hash, su implementación con BCrypt y las reglas: `UsuarioNegocio`, `IntentoLoginNegocio` |
| Presentación | `Presentacion/` | Formularios (vistas), interfaces de vista y presentadores |

La Presentación **no** referencia a Datos ni a MySQL: solo habla con Negocio.

### Requisito #1 — Dos contratos independientes en Negocio

```csharp
// Contrato 1: su única responsabilidad es GENERAR el hash
public interface IHashService
{
    string GenerarHash(string textoPlano);
}

// Contrato 2: su única responsabilidad es VERIFICAR la contraseña contra el hash
public interface IVerificarHashService
{
    bool Verificar(string textoPlano, string hashAlmacenado);
}
```

- **Implementación:** `BcryptPasswordService` implementa los dos contratos con `BCrypt.Net.BCrypt.HashPassword(...)` y `BCrypt.Net.BCrypt.Verify(...)` (factor de trabajo 11).
- **Uso:** `UsuarioNegocio` recibe los dos contratos por el constructor. Al **registrar** usa `IHashService` y manda a Datos solo el hash; al **iniciar sesión** usa `IVerificarHashService`.
- **Desacoplamiento:** el algoritmo se elige en un solo lugar (`Program.cs`). Para cambiar a otro algoritmo solo se cambia esa línea; la Vista, el Presentador y la Base de Datos no se tocan.

### Patrón MVP

| Pantalla | Vista (formulario) | Interfaz de la vista | Presentador |
| --- | --- | --- | --- |
| Inicio de sesión | `FrmLogin` | `ILoginView` | `LoginPresenter` |
| Menú principal | `FrmPrincipal` | `IPrincipalView` | `PrincipalPresenter` |
| Inicio (sumario y reloj) | `UcInicio` | `IInicioView` | `InicioPresenter` |
| Usuarios (registro) | `UcUsuarios` | `IUsuariosView` | `UsuariosPresenter` |
| Historial de accesos | `UcHistorial` | `IHistorialView` | `HistorialPresenter` |

- **Vista:** solo muestra controles y le avisa al presentador. No sabe qué es un hash ni toca la base de datos.
- **Presentador:** recibe la acción, valida, le pide el trabajo a la capa de Negocio y le dice a la vista qué mostrar. Solo conoce la *interfaz* de la vista, por eso se puede probar sin abrir ventanas.
- **Modelo:** las capas de Negocio, Datos y Entidades.

### Requisito #2 — Menú lateral, hora y sesión

| Requisito | Cómo se cumple |
| --- | --- |
| Menú en la parte izquierda | `FrmPrincipal` tiene el panel `pnlMenu` acoplado a la izquierda con Inicio, Usuarios, Historial de accesos y Cerrar sesión. El botón de la pantalla actual se marca. |
| Hora actual | Siempre visible en la barra superior (`lblHoraBarra` y `lblFechaBarra`) y en grande en el Inicio, como en la imagen de referencia. Un `Timer` la actualiza cada segundo. |
| Quién inició sesión, en la parte inferior | El panel `pnlSesion`, abajo del menú, muestra el avatar, el nombre completo, el `@usuario` y la hora de inicio de sesión. |

### Requisitos del Parcial 3 (punto 3)

| Requisito | Cómo se cumple |
| --- | --- |
| Login en C# con BCrypt (BCrypt.Net-Next) | `FrmLogin` → `LoginPresenter` → `UsuarioNegocio.IniciarSesion` |
| Generar un hash de una palabra clave en la BD | Módulo **Usuarios**: al registrar, se genera el hash con BCrypt y se guarda en `Usuarios.PasswordHash`. El script 01 también inserta `admin` con el hash de `Admin123*`. |
| Verificar con `BCrypt.Verify()` | `BcryptPasswordService.Verificar` |
| Indicar el nombre del usuario al entrar | Mensaje "¡Bienvenido(a), *nombre*!", saludo en el Inicio y nombre en la parte inferior del menú |
| Guardar intentos fallidos y exitosos, usuario y fecha | Tabla `IntentosLogin`. Se ven en el módulo **Historial de accesos** y en las tarjetas del Inicio; el script 02 tiene consultas de análisis. |
| Backup de la BD en el repositorio | `BaseDeDatos/LoginBCryptDB_backup.sql` |

### Conexión con privilegios mínimos

El programa **no** usa `root`. Se conecta como `app_login`, creado por el script 03, que solo tiene:

```sql
GRANT SELECT, INSERT ON LoginBCryptDB.Usuarios      TO 'app_login'@'localhost';
GRANT SELECT, INSERT ON LoginBCryptDB.IntentosLogin TO 'app_login'@'localhost';
```

No puede borrar ni modificar datos, cambiar tablas ni ver otras bases de datos, y solo se conecta desde la misma computadora.

### Otras medidas de seguridad

- Las contraseñas nunca se guardan: solo el hash BCrypt, que incluye su propia sal.
- Todas las consultas usan parámetros (`@NombreUsuario`, etc.) para evitar inyección SQL.
- Mensaje genérico "Usuario o contraseña incorrectos" para no revelar cuál de los dos falló.
- Validaciones: campos obligatorios; usuario de 3 a 50 caracteres (letras, números o `_`); contraseña de 6 a 72 caracteres; confirmación igual; usuario no repetido.
- Si MySQL no responde, se muestra un error de conexión (no un falso "contraseña incorrecta").

### Controles utilizados

| Control | Dónde se usa |
| --- | --- |
| `Form` | `FrmLogin` y `FrmPrincipal`, sin borde (`FormBorderStyle.None`) y con botones propios de minimizar, maximizar y cerrar |
| `UserControl` | Los módulos `UcInicio`, `UcUsuarios` y `UcHistorial`, que se cargan dentro del panel de contenido |
| `Panel` | Menú lateral, barra superior, panel de sesión, contenido y tarjetas |
| `FlowLayoutPanel` | Fila de tarjetas del sumario en el Inicio |
| `Label` | Títulos, reloj, fecha, datos de la sesión, avatar e íconos |
| `TextBox` | Usuario y contraseña (`UseSystemPasswordChar` para ocultarla) |
| `CheckBox` | "Mostrar contraseña" en el login |
| `Button` | Opciones del menú, Ingresar, Registrar, Actualizar y botones de la ventana |
| `DataGridView` | Últimos accesos, usuarios registrados e historial de intentos |
| `Timer` | Actualiza la hora cada segundo |
| `MessageBox` | Bienvenida, confirmaciones y errores |

Los íconos usan la fuente **Segoe MDL2 Assets**, que viene con Windows 10 y 11.

---

## Punto 1 — Clase abstracta y polimorfismo

| Elemento pedido | Dónde está |
| --- | --- |
| Clase abstracta (molde obligatorio) | `Figuras/Figura.cs` → `public abstract class Figura` |
| Métodos abstractos desarrollados en los hijos | `CalcularArea()` y `CalcularPerimetro()` con `override` en `Rectangulo`, `Cuadrado` y `Triangulo` |
| Arreglo unidimensional de tipo padre | `Program.cs` → `Figura[] figuras = new Figura[4];` |
| Recorrido polimórfico | `foreach (Figura figura in figuras)`: la variable es de tipo `Figura`, pero se ejecuta el método del objeto real. El nombre de la clase se obtiene con `figura.GetType().Name` |

**Salida:**

```text
=== Parcial 3 - Punto 1: Clase abstracta y polimorfismo ===

Figura            Área    Perímetro
-----------------------------------
Rectangulo       15.00        16.00
Cuadrado         36.00        24.00
Triangulo         6.00        12.00
Rectangulo       10.00        13.00

Total de figuras en el arreglo: 4
```

---

## Punto 2 — JSON con Newtonsoft.Json

1. Instalar: `dotnet add package Newtonsoft.Json`
2. Importar: `using Newtonsoft.Json;`
3. Crear el objeto `persona` con Nombre, Edad y Carrera.
4. Convertirlo con `JsonConvert.SerializeObject(persona)`.

**Salida:**

```text
Hello, World!
{"Nombre":"Cristell","Edad":20,"Carrera":"Ingenieria en Sistemas"}
```

---

## Imágenes resultantes del sistema

### Inicio de sesión
![Login](images/01_login.png)

### Validación: usuario o contraseña incorrectos
![Error de login](images/02_login_error.png)

### Acceso exitoso con el nombre del usuario
![Bienvenida](images/03_bienvenida.png)

### Menú principal: menú lateral, hora y usuario de la sesión
![Inicio](images/04_inicio.png)

### Registro de usuario (genera el hash BCrypt)
![Registro](images/05_registro.png)

### Usuarios registrados con su hash
![Usuarios](images/06_usuarios.png)

### Historial de accesos (intentos exitosos y fallidos)
![Historial](images/07_historial.png)

### Datos en MySQL Workbench
![MySQL](images/08_mysql.png)

### Punto 1 y Punto 2 en consola
![Figuras](images/09_figuras.png)
![JSON](images/10_json.png)

---

## Instalación y ejecución

### Requisitos

- Windows 10 u 11
- Visual Studio con la carga de trabajo "Desarrollo de escritorio de .NET" y el SDK de .NET 10
- MySQL Server 8 y MySQL Workbench

### Pasos

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/Shiraishi31/Parcial_2_HPA-III.git
   ```
2. En MySQL Workbench, conectado como `root`, ejecutar con el rayo (Ctrl + Shift + Enter), **en este orden**:
   1. `BaseDeDatos/01_CrearBaseDeDatos.sql` → base de datos, tablas y usuario `admin` *(o restaurar el backup, ver abajo)*.
   2. `BaseDeDatos/03_UsuarioAplicacion.sql` → usuario `app_login` que usa el programa.
3. Abrir `Parcial_3.slnx` en Visual Studio. Los paquetes NuGet se descargan solos al compilar.
4. Clic derecho en **Presentacion** → **Establecer como proyecto de inicio** → **F5**.
   Para los puntos 1 y 2, establecer como inicio `Punto1_Figuras` o `Punto2_Json`.

Usuario de prueba: **admin** / **Admin123\***

---

## Backup de la base de datos

`BaseDeDatos/LoginBCryptDB_backup.sql` contiene la estructura y los datos de `LoginBCryptDB`.

**Restaurar:** Workbench → **Server → Data Import** → **Import from Self-Contained File** → elegir el archivo → **Start Import**. Después ejecutar el script 03.

**Volver a generarlo** (por ejemplo, después de hacer pruebas, para que incluya los intentos):
Workbench → **Server → Data Export** → marcar `loginbcryptdb` → **Export to Self-Contained File** →
guardar como `BaseDeDatos/LoginBCryptDB_backup.sql` → marcar **Include Create Schema** → **Start Export**.

---

## Estructura del proyecto

```text
Parcial_3/
├── Parcial_3.slnx                      ← abre todo
├── README.md
├── BaseDeDatos/
│   ├── 01_CrearBaseDeDatos.sql         ← base de datos, tablas y usuario admin
│   ├── 02_ConsultasAnalisis.sql        ← consultas para analizar los intentos
│   ├── 03_UsuarioAplicacion.sql        ← usuario de MySQL con privilegios mínimos
│   └── LoginBCryptDB_backup.sql        ← backup
├── Punto1_Figuras/                     ← consola: clase abstracta y polimorfismo
├── Punto2_Json/                        ← consola: Newtonsoft.Json
├── Punto3_LoginBCrypt/
│   ├── Entidades/                      ← Usuario, IntentoLogin, ResumenAccesos
│   ├── Datos/                          ← Conexion, UsuarioRepositorio, IntentoLoginRepositorio
│   ├── Negocio/
│   │   ├── IHashService.cs             ← contrato 1: generar hash
│   │   ├── IVerificarHashService.cs    ← contrato 2: verificar hash
│   │   ├── BcryptPasswordService.cs    ← implementación con BCrypt
│   │   ├── UsuarioNegocio.cs           ← login y registro
│   │   └── IntentoLoginNegocio.cs      ← historial y sumario
│   └── Presentacion/
│       ├── Program.cs                  ← elige la implementación de los contratos
│       ├── Vistas/                     ← interfaces de las vistas (MVP)
│       ├── Presentadores/              ← presentadores (MVP)
│       ├── Formularios/                ← FrmLogin, FrmPrincipal
│       ├── Modulos/                    ← UcInicio, UcUsuarios, UcHistorial
│       └── Utilidades/                 ← íconos, colores, formatos, estilo de tablas
└── images/                             ← capturas de pantalla
```
