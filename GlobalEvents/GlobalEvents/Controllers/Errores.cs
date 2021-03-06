﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GlobalEvents.Controllers
{
    public static class Errores
    {
        public static ViewResult MostrarError(DatosErrores Error, ViewModels.Errores error = null)
        {
            // Ver si acá seguimos mostrando una vista general o la vamos cambiando.
            ViewResult Resultado = null;
            switch(Error)
            {
                case DatosErrores.ErrorParametros:
                    Resultado = new ViewResult
                    {
                        ViewName = "~/Views/Shared/Error.cshtml"
                    };
                break;
                case DatosErrores.Permisos:
                    Resultado = new ViewResult
                    {
                        ViewName = "~/Views/Shared/PermisosNecesarios.cshtml"
                    };
                    break;
                case DatosErrores.Otro:
                    Resultado = new ViewResult
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                    };
                    break;
            }
            return Resultado;
        }
    }

    public enum DatosErrores
    {
        ErrorParametros = 1,
        Permisos = 2,
        Otro = 3
    }
}