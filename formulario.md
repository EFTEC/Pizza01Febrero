# Formulario

## vista


Notas:

- Es necesario que todos los \<input> tengan los nombre de la propiedad
- Es necesario que exista un boton de submit
- Es necesario que exista un formulario post

## controlador

    [HttpGet]
    public ActionResult Login()
    {
        Modelo objeto=new Modelo();
        return View(objeto);
    }
.

    [HttpPOST]
    public ActionResult Login(Modelo objeto)
    {
        // aqui hacemos el trabajo
        return View(objeto);
    }