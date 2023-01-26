@ModelType IEnumerable(Of WebApplication1.Administrator)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FIO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EMAIL)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Kompleksi.Razpolojenie)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Zali.ID_Administrator)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FIO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EMAIL)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Kompleksi.Razpolojenie)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Zali.ID_Administrator)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID_Administratora }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID_Administratora }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID_Administratora })
        </td>
    </tr>
Next

</table>
