using System;
using System.Collections.Generic;
using System.Text;
using DeliverySystem.DAL.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Delivery_Service.API.HtmlHelpers
{
    public static class ListHtmlHelper
    {
        public static HtmlString CreateList(IEnumerable<Product> products)
        {
            var table = new StringBuilder();
            table.Append("<table>");
            foreach (var product in products)
            {
                table.Append("<tr>");
                table.Append($"<td>{product.Name}</td>");
                table.Append($"<td>{product.Price}</td>");
                table.Append($"<td><a href = '/mvc/product/Edit/{product.Id}'>Edit</a></td>");
                table.Append($"<td><a href = '/mvc/product/Delete/{product.Id}'>Delete</a></td>");
                table.Append("</tr>");
            }
            table.Append("</table>");
            return new HtmlString(table.ToString());
        }
    }
}
