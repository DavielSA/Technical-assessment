
## Technical assessment - Malaga (Evaluación técnica - Málaga)

### Foreword (Prólogo)

1.- Create a simple Web API that can operate on Holiday Homes data for a specific Holiday Home Owner.
<span style="color:blue">(Crear una simple Web API que pueda funcionar con los datos de las casas de vacaciones para un propietario específico de una casa de vacaciones.)
</span>

* [ ] Holiday Home Owner - an entity that owns Holiday Home(s).
<span style="color:blue">(Propietario de casa de vacaciones - una entidad que es propietaria de casa(s) de vacaciones)
</span>
* [ ] Holiday Home - single property that can be rented out.
<span style="color:blue">(Casa de vacaciones - una sola propiedad que puede ser alquilada)</span>

2.- Create a simple Vue.js or Angular.js Web app that can consume the Web API and:
<span style="color:blue">(Crear una simple aplicación web Vue.js o Angular.js que pueda consumir el Web API) </span>
* [ ] List Owners.
<span style="color:blue">(Propietarios de la lista)</span>
* [ ] List Properties when Owner selected.
<span style="color:blue">(Listar las propiedades cuando se selecciona el propietario)</span>
* [ ] CRUD operations for Owner and Holiday Home.
<span style="color:blue">(Operaciones del CRUD para el propietario y la casa de vacaciones)</span>

3.- Bonus:
<span style="color:blue">(Bono)</span>

* [ ] Add authentication (BASIC auth) to the Web API, so the Web App cannot consume the API without being authenticated.
<span style="color:blue">(Añadir autenticación (autenticación BÁSICA) a la API Web, de modo que la aplicación Web no pueda consumir la API sin estar autenticada)</span>

### Requirements (Requisitos)

* [ ] Create a public repository on GitHub and share the link by sending it to my email.
<span style="color:blue">(Crear un repositorio público en GitHub y compartir el enlace enviándolo a mi correo electrónico)</span>
* [ ] Do not use names like Spain Holiday in the public repository.
<span style="color:blue">(No use nombres como Vacaciones en España en el depósito público)</span>

### Deadline (Fecha límite)

31/07/2020 at 16:00 PM

### Acceptance criteria (Criterios de aceptación)

* [ ] [ASP.NET](http://asp.net/) Web API or [ASP.NET](http://asp.net/) Core API.
* [ ] Responses should be in application/json content type.
<span style="color:blue">(Las respuestas deben ser de tipo aplicación/contenido json)</span>
* [ ] Entity Framework or EF Core for Entity persistence.
<span style="color:blue">(Marco de la entidad o núcleo de la EF para la persistencia de la entidad)</span>
* [ ] One to many relationship between holiday homeowner and holiday homes (one owner can have zero or many holiday homes).
<span style="color:blue">(Una relación de uno a muchos entre el propietario de la casa de vacaciones y las casas de vacaciones (un propietario puede tener cero o muchas casas de vacaciones))</span>
* [ ] GET all holiday homeowners endpoint.
<span style="color:blue">(Conseguir que todos los propietarios de casas de vacaciones terminen)</span>
* [ ] CRUD endpoints for Holiday Homes.
<span style="color:blue">(Los puntos finales del CRUD para las casas de vacaciones)</span>
* [ ] It should not be possible to create a Holiday Home with owner id that does not exist.
<span style="color:blue">(No debería ser posible crear una casa de vacaciones con identificación de propietario que no existe)</span>

Bonus:
<span style="color:blue">(Bono)</span>

* [ ] Demonstrate indentation of Sass in Web App.
<span style="color:blue">(Demostrar la hendidura de Sass en la aplicación web)</span>
* [ ] Demonstration of mixins and functions in Sass in Web App.
<span style="color:blue">(Demostración de mezclas y funciones en Sass en Web App)</span>
* [ ] BASIC auth authentication implemented.
<span style="color:blue">(Se ha implementado la autenticación de autenticación BÁSICA)</span>
* [ ] GET holiday homes by owner id with paging endpoint (should return 5 holiday homes at a time).
<span style="color:blue">(Consigue casas de vacaciones por identificación del propietario con un punto final de paginación (debe devolver 5 casas de vacaciones a la vez))</span>
* [ ] Unit tests for covering the paging functionality.
<span style="color:blue">(Pruebas de unidad para cubrir la funcionalidad de paginación)</span>

### Additional information (Información adicional)

* [ ] Feel free to use any tech that you find suitable and helpful to complete the assessment.
<span style="color:blue">(Siéntase libre de usar cualquier tecnología que encuentre adecuada y útil para completar la evaluación)</span>


### Development

## Instal dB
1. Tools.
1. NuGet Package Manager.
1. Package Manager Console.
1. Execute the command:
   Add-Migration InitialCreate
## For run FrontEnd
1. Command Line
1. Execute the next command 
    cd path to /html
1. npm run


## Fixing some bug to upload code. (solved)
The repository has marked the folder html as untracked. To solve this we can run the following command:
1. $ git rm -rf --cached folderUntracked
1. $ git add folderUntracked/.
1. $ git commit -m "Your commit"
1. $ git push
