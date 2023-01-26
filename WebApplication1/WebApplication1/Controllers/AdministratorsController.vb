Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication1

Namespace Controllers
    Public Class AdministratorsController
        Inherits System.Web.Mvc.Controller

        Private db As New Sportivnii_kompleksEntities

        ' GET: Administrators
        Function Index() As ActionResult
            Dim administrator = db.Administrator.Include(Function(a) a.Kompleksi).Include(Function(a) a.Zali)
            Return View(administrator.ToList())
        End Function

        ' GET: Administrators/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim administrator As Administrator = db.Administrator.Find(id)
            If IsNothing(administrator) Then
                Return HttpNotFound()
            End If
            Return View(administrator)
        End Function

        ' GET: Administrators/Create
        Function Create() As ActionResult
            ViewBag.ID_Kompleksa = New SelectList(db.Kompleksi, "ID_Kompleksa", "Razpolojenie")
            ViewBag.ID_Zala = New SelectList(db.Zali, "ID_Zala", "ID_Administrator")
            Return View()
        End Function

        ' POST: Administrators/Create
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        'Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_Administratora,ID_Zala,ID_Kompleksa,FIO,EMAIL")> ByVal administrator As Administrator) As ActionResult
            If ModelState.IsValid Then
                db.Administrator.Add(administrator)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ID_Kompleksa = New SelectList(db.Kompleksi, "ID_Kompleksa", "Razpolojenie", administrator.ID_Kompleksa)
            ViewBag.ID_Zala = New SelectList(db.Zali, "ID_Zala", "ID_Administrator", administrator.ID_Zala)
            Return View(administrator)
        End Function

        ' GET: Administrators/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim administrator As Administrator = db.Administrator.Find(id)
            If IsNothing(administrator) Then
                Return HttpNotFound()
            End If
            ViewBag.ID_Kompleksa = New SelectList(db.Kompleksi, "ID_Kompleksa", "Razpolojenie", administrator.ID_Kompleksa)
            ViewBag.ID_Zala = New SelectList(db.Zali, "ID_Zala", "ID_Administrator", administrator.ID_Zala)
            Return View(administrator)
        End Function

        ' POST: Administrators/Edit/5
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        'Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_Administratora,ID_Zala,ID_Kompleksa,FIO,EMAIL")> ByVal administrator As Administrator) As ActionResult
            If ModelState.IsValid Then
                db.Entry(administrator).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ID_Kompleksa = New SelectList(db.Kompleksi, "ID_Kompleksa", "Razpolojenie", administrator.ID_Kompleksa)
            ViewBag.ID_Zala = New SelectList(db.Zali, "ID_Zala", "ID_Administrator", administrator.ID_Zala)
            Return View(administrator)
        End Function

        ' GET: Administrators/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim administrator As Administrator = db.Administrator.Find(id)
            If IsNothing(administrator) Then
                Return HttpNotFound()
            End If
            Return View(administrator)
        End Function

        ' POST: Administrators/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim administrator As Administrator = db.Administrator.Find(id)
            db.Administrator.Remove(administrator)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
