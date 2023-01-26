@ModelType WebApplication1.Administrator
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Administrator</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FIO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FIO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EMAIL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EMAIL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Kompleksi.Razpolojenie)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Kompleksi.Razpolojenie)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Zali.ID_Administrator)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Zali.ID_Administrator)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_Administratora }) |
    @Html.ActionLink("Back to List", "Index")
</p>
