'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан по шаблону.
'
'     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
'     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Administrator
    Public Property ID_Administratora As String
    Public Property ID_Zala As String
    Public Property ID_Kompleksa As String
    Public Property FIO As String
    Public Property EMAIL As String

    Public Overridable Property Kompleksi As Kompleksi
    Public Overridable Property Zali As Zali
    Public Overridable Property Zali1 As ICollection(Of Zali) = New HashSet(Of Zali)

End Class