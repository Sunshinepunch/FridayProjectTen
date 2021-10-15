
@{
  Layout = "_Layout";
}

@model Factory.Models.Engineer

<h2>Edit</h2>

<h4>Edit this Engineer: @Html.DisplayFor(model => model.Name)</h4>

@using (Html.BeginForm())
{
  @Html.HiddenFor(model => model.EngineerId)

  @Html.LabelFor(model => model.Name)
  @Html.EditorFor(model => model.Name)


  <input type="submit" value="Save" />
}
<p>@Html.ActionLink("Back to list", "Index")</p>