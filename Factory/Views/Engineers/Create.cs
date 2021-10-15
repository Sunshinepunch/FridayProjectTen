@{
  Layout = "_Layout";
}

@model Factory.Models.Engineer

<h4>Add an engineer</h4>
@using (Html.BeginForm())
{
  @Html.LabelFor(model => model.Name)
  @Html.TextBoxFor(model => model.Name)


  <input type="submit" value="Add new Engineer" />
}
<p>@Html.ActionLink("Show all engineers", "Index")</p>