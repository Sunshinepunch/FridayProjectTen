@{
  Layout = "_Layout";
}

@model Factory.Models.Engineer

<h2>Engineer Details</h2>
<hr />
<h3>@Html.DisplayNameFor(model => model.Name): @Html.DisplayFor(model => model.Name)</h3>

@if(@Model.JoinEntities.Count == 0)
{
  <p>'This engineer is not assigned to any machines'</p>
}
else
{
  <h4>'Machines this engineer is assigned to':</h4>
  <ul>
  @foreach(var join in Model.JoinEntities)
  {
    <li>@join.Machine.Name</li>
  }
  </ul>
}

<p>@Html.ActionLink("Back to Engineers", "Index")</p>
<p>@Html.ActionLink("Edit Engineer", "Edit", new { id = Model.EngineerId })</p>
<p>@Html.ActionLink("Delete Engineer", "Delete", new { id = Model.EngineerId })</p>