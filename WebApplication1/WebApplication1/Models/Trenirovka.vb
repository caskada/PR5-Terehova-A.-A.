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

Partial Public Class Trenirovka
    Public Property ID_Trenirovka As String
    Public Property ID_Klienta As String
    Public Property ID_Zala As String
    Public Property ID_Kompleksa As String
    Public Property ID_Zapis_ As String
    Public Property ID_Moderator As String
    Public Property Kolichestvo As String
    Public Property Vremya As System.TimeSpan

    Public Overridable Property Klienti As Klienti
    Public Overridable Property Kompleksi As Kompleksi
    Public Overridable Property Moderator As ICollection(Of Moderator) = New HashSet(Of Moderator)
    Public Overridable Property Moderator1 As Moderator
    Public Overridable Property Zali As Zali
    Public Overridable Property Zapis__na_trenirovku As Zapis__na_trenirovku
    Public Overridable Property Zapis__na_trenirovku1 As ICollection(Of Zapis__na_trenirovku) = New HashSet(Of Zapis__na_trenirovku)

End Class
