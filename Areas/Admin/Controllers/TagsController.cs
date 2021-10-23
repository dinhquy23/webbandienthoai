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
    public class TagsController : Controller
    {
        IConfiguration configuration;

        public TagsController(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }
        public IActionResult Index(int? page)
        {
            DataTable dtTags = new DataTable();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Tags  order by id desc", conn);
                da.Fill(dtTags);
            }
            List<Tags> listCategory = new List<Tags>();
            foreach (DataRow item in dtTags.Rows)
            {
                listCategory.Add(
                    new Tags()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString()
                    }
);
            }
            int _CurrentPage = page ?? 1;
            int _RecordPage = 20;
            return View("Index", listCategory.ToPagedList(_CurrentPage, _RecordPage));
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
                SqlCommand cmd = new SqlCommand("insert into Tags(Name) values(@name)", conn);
                cmd.Parameters.AddWithValue("name", _name);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Tags");
        }
        public IActionResult Update(int? id)
        {
            int _id = id ?? 0;
            DataTable dtTags = new DataTable();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Tags where ID=" + _id, conn);
                da.Fill(dtTags);
            }
            DataRow itemCategory = dtTags.NewRow();
            if (dtTags.Rows.Count > 0)
            {
                itemCategory = dtTags.Rows[0];
            }
            return View("Create", itemCategory);
        }
        [HttpPost]
        public IActionResult Update(IFormCollection fc, int? id)
        {
            int _id = id ?? 0;
            string _name = fc["name"].ToString().Trim();
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Tags set Name = @name where ID = @id", conn);
                cmd.Parameters.AddWithValue("@name", _name);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Tags");
        }
        public IActionResult Delete(int? id)
        {
            int _id = id ?? 0;
            string strDBConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            using (SqlConnection conn = new SqlConnection(strDBConnectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Tags where ID=@id", conn);
                cmd.Parameters.AddWithValue("id", _id);
                cmd.ExecuteNonQuery();
            }
            return Redirect("/Admin/Tags");
        }

    }
}
