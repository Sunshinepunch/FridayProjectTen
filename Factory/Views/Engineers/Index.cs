// @{
//   Layout = "_Layout";
// }

// @using Factory.Models;

// <h1>Engineers</h1>

// @if (@Model.Count == 0)
// {
//   <h3>No Engineers have been added yet!</h3>
// } 

// <ul>
//   @foreach(Engineer engineer in Model)
//   {
//     <li>@Html.ActionLink($"{engineer.Name}", "Details", new { id = engineer.EngineerId })</li>
//   }
// </ul>

// <p>@Html.ActionLink("Add new Engineer", "Create")</p>
// <p>@Html.ActionLink("Home", "Index", "Home")</p>