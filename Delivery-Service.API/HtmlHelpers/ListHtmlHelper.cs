using System;
using System.Collections.Generic;
using DeliverySystem.DAL.Models;
using Microsoft.AspNetCore.Html;

namespace Delivery_Service.API.HtmlHelpers
{
    public static class ListHtmlHelper
    {
        public static HtmlString CreateList(IEnumerable<Product> products)
        {
            var table = "<table>";
            foreach (var product in products)
            {
                table += "<tr>";
                table += $"<td>{product.Name}</td>";
                table += $"<td>{product.Price}</td>";
                table += $"<td><a href = '/mvc/product/Edit/{product.Id}'>Edit</a></td>";
                table += $"<td><a href = '/mvc/product/Delete/{product.Id}'>Delete</a></td>";
                table += "</tr>";
            }
            table += "</table>";
            return new HtmlString(table);
        }
    }
}
