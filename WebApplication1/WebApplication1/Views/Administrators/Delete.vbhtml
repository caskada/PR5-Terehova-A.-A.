@ModelType WebApplication1.Administrator
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
