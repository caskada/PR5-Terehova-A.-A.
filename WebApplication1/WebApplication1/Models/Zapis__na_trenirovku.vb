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

Partial Public Class Zapis__na_trenirovku
    Public Property ID_Zapis_ As String
    Public Property ID_Trenirovka As String
    Public Property ID_Trener As String
    Public Property Vremya As System.TimeSpan
    Public Property data As Date

    Public Overridable Property Trener As Trener
    Public Overridable Property Trenirovka As ICollection(Of Trenirovka) = New HashSet(Of Trenirovka)
    Public Overridable Property Trenirovka1 As Trenirovka

End Class