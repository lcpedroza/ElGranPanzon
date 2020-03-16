using DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAccess.Tablas;

namespace Web.Controllers
{
    public class InsumoController : Controller {

        private DataAccess.Tablas.Entidades db;

        public InsumoController() {
            db = new DataAccess.Tablas.Entidades();
        }

        public ActionResult AgregarProducto() {
            var insumoDao = new InsumoDao(db);
            var insumos = insumoDao.GetInsumos();
            ViewBag.Insumos = insumos;
            return View();

        }

        public ActionResult AgregarInsumo() {
            var empleadoLogueado = (Empleado)Session["empleado"];

            var inventario = new Inventario();

            inventario.InsumoId = Convert.ToInt32(Request.Form.Get("insumos"));
            inventario.MovimientoCantidad = Convert.ToInt32(Request.Form.Get("cantidad"));

            inventario.SedeId = empleadoLogueado.SedeId;
            var inventarioDao = new InventarioDao(db);
            inventarioDao.CrearInventario(inventario);
            Response.Redirect("/Insumo/VerInsumos");
            return View();
        }

        public ActionResult VerInsumos() {

            var insumoDao = new InsumoDao(db);
            var insumos = insumoDao.GetInsumos();

            ViewBag.Insumos = insumos;
            return View();
        }

        public ActionResult VerInventarioGeneral() {

            var insumoDao = new InsumoDao(db);
            var insumos = insumoDao.GetInsumos();

            ViewBag.Insumos = insumos;
            return View();
        }
        public ActionResult EntregarInsumo() {
            var insumoDao = new InsumoDao(db);
            var insumos = insumoDao.GetInsumos();
            ViewBag.Insumos = insumos;
            return View();
        }

        public ActionResult RestarInsumo() {
            var empleadoLogueado = (Empleado)Session["empleado"];

            var inventario = new Inventario();

            inventario.InsumoId = Convert.ToInt32(Request.Form.Get("insumos"));
            inventario.MovimientoCantidad = -Convert.ToInt32(Request.Form.Get("cantidad"));

            inventario.SedeId = empleadoLogueado.SedeId;
            var inventarioDao = new InventarioDao(db);
            inventarioDao.CrearInventario(inventario);
            Response.Redirect("/Insumo/VerInsumos");
            return View();
        }
    }
}
