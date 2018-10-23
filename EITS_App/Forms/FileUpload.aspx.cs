using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using IOM.EITS.DAL;
namespace EITS_App.Forms
{
    public partial class FileUpload :EITS_App.BaseController .BaseController  
    {
        string[] files;
        DataTable dt = new DataTable("datatable1");
        DataColumn dc;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
              //  FillGrid("", 0);
                _FillCombo();
                LoadUploadedFiles(ref _gvList);                
            }
        }
        // 

        private Guid UserId
        {
            get
            {
                if (Session["UserId"] != null) return (Guid)Session["UserId"];
                else return Guid.Empty;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = "";
            string stFileName = f_load.FileName;
            if(this.ddlStaffmember.SelectedIndex ==0)
            {
                this.lblMessage.Text = "Please select the Staff Member to show Files";
                return;
            }
            else if(!this.f_load.HasFile )
            {
                LoadUploadedFiles(ref _gvList);
            }
            else 
            {
                try
                {
                 if (!Directory.Exists(Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember.SelectedValue.ToString())))
                        Directory.CreateDirectory(
                            Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember.SelectedValue.ToString()+"\\"));
                    f_load.PostedFile.SaveAs(
                        Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember.SelectedValue.ToString() + "\\" + f_load.PostedFile.FileName ));
                    LoadUploadedFiles(ref _gvList);
                    //FillGrid("",0);
                }
                catch (Exception)
                {
                    throw;
                }
           }
   }
        protected void btnSavePerson_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAttachment();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        protected void imgDelete_Command(object sender, CommandEventArgs e)
        {
            EITSDB _obj = new EITSDB();
            tblStaff_FilesRow row_ = new tblStaff_FilesRow();
            try
            {
                string strPath = Path.Combine(".\\fileuploads\\" + ddlStaffmember.SelectedValue.ToString(),
                                              e.CommandArgument.ToString());
                if(File.Exists(strPath ))
                {
                    File.Delete(strPath );
                    this.lblMessage.Text = "Selected File <strong> Deleted</strong> successfully!";
                    LoadUploadedFiles(ref _gvList);
                    dbdeleteRecord(e.CommandArgument.ToString(), this.ddlStaffmember.SelectedValue.ToString( ));
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void dbdeleteRecord(object fpathname, string staff)
        {
            EITSDB _obj = new EITSDB();
            tblStaff_FilesRow row_ = new tblStaff_FilesRow();
            try
            {
                string aurg = "PATH=N'" + System.IO.Path.GetFileName(fpathname.ToString()) + "' AND STAFFID=" +
                             Convert .ToInt32(  this.ddlStaffmember.SelectedValue.ToString());
                _obj.tblStaff_FilesCollection.Delete(aurg );
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void lblPath_Command(object sender, CommandEventArgs e)
        {
            downLoadFile(e.CommandArgument.ToString());
            //System.Diagnostics.Process.Start(e.CommandArgument.ToString());
        }


        // Supporting Methods

            #region downloadFile
            public void downLoadFile(string filePath)
            {
                if (File.Exists(filePath))
                {
                    string strFileName = Path.GetFileName(filePath).Replace(" ", "%20");
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + strFileName);
                    Response.Clear();
                    Response.WriteFile(filePath);
                    Response.End();
                }
            }
            #endregion
            #region CalculateFileSize
            public string CalculateFileSize(double FileInBytes)
            {
                string strSize = "00";
                if (FileInBytes < 1024)
                    strSize = FileInBytes + " B";//Byte
                else if (FileInBytes > 1024 & FileInBytes < 1048576)
                    strSize = Math.Round((FileInBytes / 1024), 2) + " KB";//Kilobyte
                else if (FileInBytes > 1048576 & FileInBytes < 107341824)
                    strSize = Math.Round((FileInBytes / 1024) / 1024, 2) + " MB";//Megabyte
                else if (FileInBytes > 107341824 & FileInBytes < 1099511627776)
                    strSize = Math.Round(((FileInBytes / 1024) / 1024) / 1024, 2) + " GB";//Gigabyte
                else
                    strSize = Math.Round((((FileInBytes / 1024) / 1024) / 1024) / 1024, 2) + " TB";//Terabyte
                return strSize;
            }
    #endregion
            #region SaveAttch
            private void SaveAttachment()
            {
                // Variables
                Int32 count_ = 0;
                EITSDB obj_ = new EITSDB();
                tblStaff_FilesRow _ObjSf = new tblStaff_FilesRow();
                string partialpath="";
                try
                {
                    for(int i=0; i <=_gvList.Rows .Count-1;i++ )
                    {
                        GridViewRow gvRow = this._gvList.Rows[i];
                        _ObjSf .StaffID = Convert.ToInt32(this.ddlStaffmember.SelectedValue.ToString());
                        string stpart = (((LinkButton)gvRow.FindControl("lblPath")).Text).ToString();
                        _ObjSf.Path = getPartString(stpart);
                        Boolean  check = CheckExist(System.IO.Path.GetFileName(stpart));
                        if (!CheckExist(System.IO.Path.GetFileName(stpart)))
                        {
                            obj_.tblStaff_FilesCollection.Insert(_ObjSf);
                            count_ = count_ + 1;
                        }
                    }
                    this.lblMessage.Text = count_ + ". File <strong>Saved</strong> to database successfully!";
                }
                catch (Exception ex)
                {
                    this.lblMessage.Text = ex.Message;
                    //throw;
                }
                finally
                {
                    obj_.Dispose();
                }
            }
            #endregion
            #region getPartString
            public string getPartString(string path)
            {
                string st = "";
                st = System.IO.Path.GetFileName(path);
                return st;
            }
            #endregion
            #region FillCombo
            public void _FillCombo()
            {
                EITSDB obj_ = new EITSDB();
                var objN = new staff();
                try
                {
                   DataTable dt= objN.getFirstLastStaffName();
                   EITSCommon.FillCombo(ref ddlStaffmember, dt, "Staff_Name", "StaffID", true);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    obj_.Dispose();
                }
            }
            #endregion
            #region "LoadUploadedFiles

            public void LoadUploadedFiles(ref GridView gv)
            {
                if(this.ddlStaffmember.SelectedIndex !=0)
                {
                    DataTable dFiles = GetFilesInDirectory(HttpContext.Current.Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember.SelectedValue.ToString()));
                    if(dFiles.Rows.Count>0)
                    {
                    this._gvList.DataSource = dFiles;
                    this._gvList.DataBind();
                    _gvList.Visible = true;
                    }
                    else
                    {
                        this.lblMessage.Text = "No <strong>Files<strong> Exists!";
                        this._gvList.Visible = false;
                    }
                }
            }
            public DataTable GetFilesInDirectory(string sourcePath)
            {
                DataTable dtFiles = new System.Data.DataTable();
                if ((Directory.Exists(sourcePath)))
                {
                    dtFiles.Columns.Add(new System.Data.DataColumn("FileIcon"));
                    dtFiles.Columns.Add(new System.Data.DataColumn("StaffId"));
                    dtFiles.Columns.Add(new System.Data.DataColumn("FilePath"));
                    dtFiles.Columns.Add(new System.Data.DataColumn("TimeUpload"));
                    dtFiles.Columns.Add(new System.Data.DataColumn("DateUpload"));
                    dtFiles.Columns.Add(new System.Data.DataColumn("filesize")); 

                    //dtFiles.Columns["Size"].DataType = typeof(double);
                    //dtFiles.Columns.Add(new System.Data.DataColumn("ConvertedSize"));
                    
                    DirectoryInfo dir = new DirectoryInfo(sourcePath+"\\");
                    foreach (FileInfo files in dir.GetFiles("*.*"))
                    {
                        DataRow drFile = dtFiles.NewRow();
                        string strFile = "";
                        drFile["FileIcon"] = GetExtention( files.Name );
                        drFile["StaffId"] = this.ddlStaffmember.SelectedValue; 
                        drFile["FilePath"] = files.FullName;
                        drFile["TimeUpload"] = DateTime.Now.ToShortDateString();
                        drFile["DateUpload"] = DateTime.Now.Date; 
                        drFile["filesize"] = CalculateFileSize(files.Length);
                        dtFiles.Rows.Add(drFile);
                    }
                }
                return dtFiles;
            }
            public string GetExtention(string _File)
            {
                string fileImage = "";
                string ext = System.IO.Path.GetExtension(_File);
                if (ext == ".pdf")
                    fileImage = "../images/pdf.gif";
                else if (ext == ".txt")
                    fileImage = "../images/txt.gif";
                else if (ext == ".doc")
                    fileImage = "../images/doc.gif";
                else if (ext == ".docx")
                    fileImage = "../images/word.png";
                else if (ext == ".xls")
                    fileImage = "../images/xls.gif";
                else if (ext == ".xlsx")
                    fileImage = "../images/excel.png";
                else if (ext == ".rar")
                    fileImage = "../images/winrar.JPG";
                else if (ext == ".zip")
                    fileImage = "../images/zip.gif";
                else if (ext == ".JPG" || ext==".JPEG" || ext==".tif" || ext ==".jpeg" || ext==".jpg")
                    fileImage = "../images/gif.gif";
                else
                    fileImage = "../images/dir.gif";
                return fileImage;
            }

            #endregion
            #region "FillGridMethod
        // Fill the Grid with Listed Files
        
        public void FillGrid(string category, int val)
        {
            DataTable dt = new DataTable("datatable1");
            DataColumn dc;
            DataRow dr;
            dr = dt.NewRow();

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "FileIcon";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "StaffId";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "FilePath";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.DateTime");
            dc.ColumnName = "TimeUpload";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.DateTime");
            dc.ColumnName = "DateUpload";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "filesize";
            dt.Columns.Add(dc);



            //files list

            if (!Directory.Exists(Server.MapPath(".\\fileupload\\" + this.ddlStaffmember.SelectedValue.ToString( )+ "\\")))
                Directory.CreateDirectory(Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember .SelectedValue.ToString( ) + "\\"));

            files = Directory.GetFiles(Server.MapPath(".\\fileuploads\\" + this.ddlStaffmember .SelectedValue .ToString( ) + "\\"));

            foreach (string fileName in files)
            {
                dr = dt.NewRow();
                string fileImage = "";
                FileInfo fi = new FileInfo(fileName);
                //

                if (fi.Extension == ".pdf")
                    fileImage = "../images/pdf.gif";
                else if (fi.Extension == ".txt")
                    fileImage = "../images/txt.gif";
                else if (fi.Extension == ".doc")
                    fileImage = "../images/doc.gif";
                else if (fi.Extension == ".xls")
                    fileImage = "../images/xls.gif";
                else
                    fileImage = "../images/png.gif";
                ////
                dr[0] = fileImage;
                dr[1] = this.ddlStaffmember.SelectedValue.ToString(CultureInfo.InvariantCulture);
                dr[2] = fi.FullName.ToString(CultureInfo.InvariantCulture);
                dr[3] = DateTime.Now.ToShortTimeString();
                dr[4] = DateTime.Now.Date;
                string size = "";
                size = CalculateFileSize(this.f_load.PostedFile.ContentLength);
                dr[5] = size;

                dt.Rows.Add(dr);

            }
            DataView dv = new DataView(dt);
            _gvList.DataSource = dv;
            _gvList.DataBind();

        }
        #endregion 
        #region CheckExistFileinDb

        public Boolean   CheckExist(string argfName)
        {
            int count = 0;
            bool recPresent = false;
            DataTable dt_ = new DataTable();
            EITSDB obj_ = new EITSDB();
            tblStaff_FilesRow row_ = new tblStaff_FilesRow();

            try
            {
                string value_ = "STAFFID=" + this.ddlStaffmember.SelectedValue.ToString() + " AND PATH='" + argfName + "'";
                row_ =obj_.tblStaff_FilesCollection.GetRow(value_);
                string test = "staffid=" + Convert.ToInt32(ddlStaffmember.SelectedValue) + " and path=N'" + argfName;
                dt_ = obj_.tblStaff_FilesCollection.GetAsDataTable("staffid=" + Convert.ToInt32(ddlStaffmember.SelectedValue) + " and path=N'" + argfName+"'", "Files_ID");

                count = Convert.ToInt32(dt.Rows.Count.ToString() + 1);
                ///return count;
                var reader = new DataTableReader(dt_);
                if (reader.HasRows)
                {
                    recPresent = true;
                }
                else
                {
                    recPresent = false;
                }
               

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                ///throw;
            }
            return recPresent;



            //string dbFileName = row_.Path.ToString();
            //if (argfName == dbFileName)
            //{
            //    flage = false ;
            //}
            //else
            //{
            //    flage = true;
            //}
            //return flage;
           
        }

        #endregion

    }
}
