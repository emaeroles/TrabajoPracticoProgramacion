# TransportesCordobaSRL

Esta solución de software fue construida en .NET 5.0, para llevar el control de los recursos y las operaciones de la empresa (ficticia) Transportes Córdoba SRL. Su principal función es la de almacenar la información referida a los camiones, sus cargas, las rutas y los conductores (usuarios), en la base de datos.

### Está dividida en 3 proyectos:

1. Una Aplicación de Windows Form, donde se encuentra lo referido al ingreso de datos por parte de los usuarios (con las validaciones necesarias) y a la visualización de la información que haya sido almacenada en la base de datos. Cuenta con un cliente HTTP para comunicarse con los endpoints de la API, utilizado en el objeto ClienteSingleton que tiene un patrón Singleton para la creación de su instancia y que usa las rutas almacenadas en los objetos Rutas. Estos últimos, tienen un padre donde se encuentra la dirección del host; la idea de crear objetos para las rutas fue pensada para hacer más fácil la gestión de estas. Además, la comunicación con la API se realiza utilizando el formato JSON. Y por último, y debido a la necesidad de usuarios, también se realiza aquí la codificación SHA256 de las contraseñas.
2. Una Web API, que cuenta con los controllers necesarios para comunicarse con el Form. Aquí hay que destacar, que la creación de las instancias de la Abstract Factory de los Servicios de la librería, se realizan mediante inyección de dependencia (a esto lo pude hacer funcionar, pero no la termino de visualizar).
3. Y una librería, que es utilizada por el Form y la API. Esta tiene las entidades, los enumeradores y un DTO (para el login), siendo estos los únicos recursos que usa el Form y que además son utilizados en la API, para gestionar los datos desde y hacia la base de datos, por sus dos capas:
    1. La capa de datos, donde se encuentran los DAOs, que realiza las acciones CRUD y que para crear sus instancias se utiliza una Abstract Factory. Estos trabajan en conjunto con el HelperDao, que tiene un patrón Singleton y es este el que accede a la base de datos. Otra característica, es que, entre los métodos del helper, hay uno que trata a los viajes y las cargas como transacciones conjuntas.
    2. Y la capa de servicios, cuenta con los Gestores, que cumplen con la función de ser el punto de acceso a la librería y que, cuentan con una Abstract Factory para crear sus instancias.

### BBDD

La Base de Datos, posee 6 tablas (2 maestras, 2 de transacciones y 2 auxiliares) y 26 Stored Procedures que son los encargados de realizar todas las acciones Create, Read, Update y Delete en las tablas. Para destacar, podemos mencionar que el procedimiento PA_LOGIN_USUARIO es el encargado de realizar la autenticación de los usuarios. La idea es que desde el frontend se envíe la información del login al backend y que el backend responda con true or false, esta pensando así, para que esta información sensible, no esté siendo enviada innecesariamente a través de internet.

---

P.D.: En la revisión que realice del código para escribir esta descripción, descubrí que éste, presenta el antipatrón de Lava Flow. Debido a que al realizar cambios sobre la marcha no tuve el cuidado de ir eliminando el código que iba quedando en desuso.

---

