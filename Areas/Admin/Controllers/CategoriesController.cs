using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Configuration;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Project.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;
using Project.Areas.Admin.Attributes;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [CheckLogin]
    public class CategoriesController : Controller
    {
        IConfiguration configuration;
        
        public CategoriesController(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }
        public IActionResult Index(int? page)
        {
            DataTable dtCategories = new DataTable();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Categories where ParentID=0 order by id desc", conn);
                da.Fill(dtCategories);
            }
            List<Categories> listCategory = new List<Categories>();
            foreach(DataRow item in dtCategories.Rows)
            {
                listCategory.Add(
                    new Categories() { 
                        ID = Convert.ToInt32(item["ID"]), 
                        ParentID = Convert.ToInt32(item["ParentID"]),
                        Name=item["Name"].ToString()
}
);
}
            int _CurrentPage = page ?? 1;
            int _RecordPage = 20;
            return View("Index",listCategory.ToPagedList(_CurrentPage,_RecordPage));
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection fc)
        {
            string _name = fc["name"].ToString().Trim();
            string _ParentID = fc["ParentID"].ToString().Trim();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Categories(Name,ParentID) values(@name,@parentID)", conn);
                cmd.Parameters.AddWithValue("name", _name);
                cmd.Parameters.AddWithValue("parentID", _ParentID);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Categories");
        }
        public IActionResult Update(int? id)
        {
            int _id = id ?? 0;
            DataTable dtCategories = new DataTable();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Categories where ID=" + _id, conn);
                da.Fill(dtCategories);
            }
            DataRow itemCategory = dtCategories.NewRow();
            if (dtCategories.Rows.Count > 0)
            {
                itemCategory = dtCategories.Rows[0];
            }
            return View("Update", itemCategory);
        }
        [HttpPost]
        public IActionResult Update(IFormCollection fc, int?id)
        {
            int _id = id ?? 0;
            string _name = fc["name"].ToString().Trim();
            string _ParentID = fc["ParentID"].ToString().Trim();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Categories set Name = @name, ParentID = @parent_id where ID = @id", conn);
                cmd.Parameters.AddWithValue("@name", _name);
                cmd.Parameters.AddWithValue("@parent_id", _ParentID);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Categories");
        }
        public IActionResult Delete(int? id)
        {
            int _id = id ?? 0;
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Categories where ID=@id or ParentID=@id", conn);
                cmd.Parameters.AddWithValue("id", _id);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Categories");
        }

    }
}
