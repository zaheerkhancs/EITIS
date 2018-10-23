using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Web.Caching;

namespace IOM.EITS.DAL
{
	/// <summary>
	/// Summary description for Message.
	/// </summary>
	public class Message
	{
		
		public Message()
		{
			// EMPTY
		}
		#region Variable Declaration
			private string Expression = "/Messages/Field";
		#endregion

		#region variables;
		
			private string _Insert_SameAlreadyExists;
			private string _Insert_UserAlreadyExists;
			private string _ErrorOccured;
			private string _Inserted_SuccessFully;
			private string _NoRecordExists;
			private string _Deleted_SuccessFully;
			private string _DeletedMultiple_SuccessFully;
			private string _Record_AlReady_Deleted;
			private string _Update_SameAlreadyExists;
			private string _LoginFailed;
			private string _PasswordRecovered;
			private string _NoUserExists;
			private string _ErrorOccured_ActionCancelled;
			private string _Search_NoCriteria;
			private string _FromDate_Greater_Todate;
			private string _Invalid_Date;
			private string _Updated_SuccessFully;
			private string _Password_Changed_Successfully;
			private string _PathNotFound;
			private string _CannotDelete_ReferenceExists;
			private string _Cart_Empty;
			private string _Please_Enter;
			private string _Please_Select;
			private string _EmailNotFound;
			private string _EmailSent;
			private string _IncorrectPwd;
			private string _Insert_EmailExists;
			private string _SqlInjectionMsg;
			private string _Invalid_Email;
			private string _ConfirmPwd_Must_Match;
			private string _SqlInjection_PwdLen;
			private string _SqlInjection_ConfirmPwdLen;
			private string _AddEditUser_AccesRights;
			private string _AddEditUser_LastSuperAdmin;
			private string _Insert_UnitNoExists;
			private string _Not_LoggedIn;
		#endregion

		#region  Properties 
		public string Insert_SameAlreadyExists
		{
			get
			{
				return _Insert_SameAlreadyExists;
			}
			set
			{
				_Insert_SameAlreadyExists = value;
			}
		}
		public string Insert_UserAlreadyExists
		{
			get
			{
				return _Insert_UserAlreadyExists;
			}
			set
			{
				_Insert_UserAlreadyExists = value;
			}
		}
		public string ErrorOccured
		{
			get
			{
				return _ErrorOccured;
			}
			set
			{
				_ErrorOccured = value;
			}
		}
		public string Inserted_SuccessFully
		{
			get
			{
				return _Inserted_SuccessFully;
			}
			set
			{
				_Inserted_SuccessFully = value;
			}
		}
		public string NoRecordExists
		{
			get
			{
				return _NoRecordExists;
			}
			set
			{
				_NoRecordExists = value;
			}
		}
		public string Deleted_SuccessFully
		{
			get
			{
				return _Deleted_SuccessFully;
			}
			set
			{
				_Deleted_SuccessFully = value;
			}
		}
		public string DeletedMultiple_SuccessFully
		{
			get
			{
				return _DeletedMultiple_SuccessFully;
			}
			set
			{
				_DeletedMultiple_SuccessFully = value;
			}
		}
		public string Record_AlReady_Deleted
		{
			get
			{
				return _Record_AlReady_Deleted;
			}
			set
			{
				_Record_AlReady_Deleted = value;
			}
		}
		public string Update_SameAlreadyExists
		{
			get
			{
				return _Update_SameAlreadyExists;
			}
			set
			{
				_Update_SameAlreadyExists = value;
			}
		}
		public string LoginFailed
		{
			get
			{
				return _LoginFailed;
			}
			set
			{
				_LoginFailed = value;
			}
		}
		public string PasswordRecovered
		{
			get
			{
				return _PasswordRecovered;
			}
			set
			{
				_PasswordRecovered = value;
			}
		}
		public string NoUserExists
		{
			get
			{
				return _NoUserExists;
			}
			set
			{
				_NoUserExists = value;
			}
		}
		public string ErrorOccured_ActionCancelled
		{
			get
			{
				return _ErrorOccured_ActionCancelled;
			}
			set
			{
				_ErrorOccured_ActionCancelled = value;
			}
		}
		public string Search_NoCriteria
		{
			get
			{
				return _Search_NoCriteria;
			}
			set
			{
				_Search_NoCriteria = value;
			}
		}
		public string FromDate_Greater_Todate
		{
			get
			{
				return _FromDate_Greater_Todate;
			}
			set
			{
				_FromDate_Greater_Todate = value;
			}
		}
		public string Invalid_Date
		{
			get
			{
				return _Invalid_Date;
			}
			set
			{
				_Invalid_Date = value;
			}
		}
		public string Updated_SuccessFully
		{
			get
			{
				return _Updated_SuccessFully;
			}
			set
			{
				_Updated_SuccessFully = value;
			}
		}
		public string Password_Changed_Successfully
		{
			get
			{
				return _Password_Changed_Successfully;
			}
			set
			{
				_Password_Changed_Successfully = value;
			}
		}

		public string PathNotFound
		{
			get
			{
				return _PathNotFound;
			}
			set
			{
				_PathNotFound = value;
			}
		}
		public string CannotDelete_ReferenceExists
		{
			get
			{
				return _CannotDelete_ReferenceExists;
			}
			set
			{
				_CannotDelete_ReferenceExists = value;
			}
		}
		public string Cart_Empty
		{
			get
			{
				return _Cart_Empty;
			}
			set
			{
				_Cart_Empty = value;
			}
		}

		public string Please_Enter
		{
			get
			{
				return _Please_Enter;
			}
			set
			{
				_Please_Enter = value;
			}
		}

		public string Please_Select
		{
			get
			{
				return _Please_Select;
			}
			set
			{
				_Please_Select = value;
			}
		}

		public string EmailNotFound
		{
			get
			{
				return _EmailNotFound;
			}
			set
			{
				_EmailNotFound = value;
			}
		}
		public string EmailSent
		{
			get
			{
				return _EmailSent;
			}
			set
			{
				_EmailSent = value;
			}
		}
		public string IncorrectPwd
		{
			get
			{
				return _IncorrectPwd;
			}
			set
			{
				_IncorrectPwd = value;
			}
		}

		public string Insert_EmailExists
		{
			get
			{
				return _Insert_EmailExists;
			}
			set
			{
				_Insert_EmailExists = value;
			}
		}
		public string Invalid_Email
		{
			get
			{
				return _Invalid_Email;
			}
			set
			{
				_Invalid_Email = value;
			}
		}
		public string ConfirmPwd_Must_Match
		{
			get
			{
				return _ConfirmPwd_Must_Match;
			}
			set
			{
				_ConfirmPwd_Must_Match = value;
			}
		}
		public string SqlInjectionMsg
		{
			get
			{
				return _SqlInjectionMsg;
			}
			set
			{
				_SqlInjectionMsg = value;
			}
		}
		public string SqlInjection_PwdLen
		{
			get
			{
				return _SqlInjection_PwdLen;
			}
			set
			{
				_SqlInjection_PwdLen = value;
			}
		}
		public string SqlInjection_ConfirmPwdLen
		{
			get
			{
				return _SqlInjection_ConfirmPwdLen;
			}
			set
			{
				_SqlInjection_ConfirmPwdLen = value;
			}
		}
		public string AddEditUser_AccesRights
		{
			get
			{
				return _AddEditUser_AccesRights;
			}
			set
			{
				_AddEditUser_AccesRights = value;
			}
		}
		public string AddEditUser_LastSuperAdmin
		{
			get
			{
				return _AddEditUser_LastSuperAdmin;
			}
			set
			{
				_AddEditUser_LastSuperAdmin = value;
			}
		}

		public string Insert_UnitNoExists
		{
			get
			{
				return _Insert_UnitNoExists;
			}
			set
			{
				_Insert_UnitNoExists = value;
			}
		}
		public string Not_LoggedIn
		{
			get
			{
				return _Not_LoggedIn;
			}
			set
			{
				_Not_LoggedIn = value;
			}
		}
		#endregion
	
		#region  Functions 
		public string loadMsg(string XmlFilePath)
		{

			XmlDocument doc = new XmlDocument();
			doc.Load(XmlFilePath);
      

			////Create XPathNavigator
			XPathNavigator xpathNav = null;
			xpathNav = doc.CreateNavigator();

			////Compile the XPath expression
			XPathExpression xpathExpr = null;
			xpathExpr = xpathNav.Compile(Expression);

			////Display the results depending on type of result
			string strOutput = null;
			string strMsgValue = null;
			string strMsgName = null;


			switch (xpathExpr.ReturnType)
			{
				case XPathResultType.String:
					strOutput = System.Convert.ToString(xpathNav.Evaluate(xpathExpr));

					break;
				case XPathResultType.NodeSet:
					XPathNodeIterator nodeIter = null;
					nodeIter = xpathNav.Select(xpathExpr);
					int nodecount = nodeIter.Count;
					while (nodeIter.MoveNext())
					{
						if (nodeIter.Current.MoveToFirstChild())
						{
							int i = 0;
							do
							{
								if (i == 0)
								{
									strMsgName = System.Convert.ToString(nodeIter.Current.Value);
								}
								else
								{
									strMsgValue = System.Convert.ToString(nodeIter.Current.Value);
									switch (strMsgName)
									{
										case "Updated_SuccessFully":
											_Updated_SuccessFully = strMsgValue;
											break;
										case "Update_SameAlreadyExists":
											_Update_SameAlreadyExists = strMsgValue;
											break;
										case "Search_NoCriteria":
											_Search_NoCriteria = strMsgValue;
											break;
										case "Insert_SameAlreadyExists":
											_Insert_SameAlreadyExists = strMsgValue;
											break;
										case "Insert_UserAlreadyExists":
											_Insert_UserAlreadyExists = strMsgValue;
											break;
										case "ErrorOccured":
											_ErrorOccured = strMsgValue;
											break;
										case "Inserted_SuccessFully":
											_Inserted_SuccessFully = strMsgValue;
											break;
										case "NoRecordExists":
											_NoRecordExists = strMsgValue;
											break;
										case "Deleted_SuccessFully":
											_Deleted_SuccessFully = strMsgValue;
											break;
										case "DeletedMultiple_SuccessFully":
											_DeletedMultiple_SuccessFully = strMsgValue;
											break;
										case "Record_AlReady_Deleted":
											_Record_AlReady_Deleted = strMsgValue;
											break;
										case "LoginFailed":
											_LoginFailed = strMsgValue;
											break;
										case "PasswordRecovered":
											_PasswordRecovered = strMsgValue;
											break;
										case "NoUserExists":
											_NoUserExists = strMsgValue;
											break;
										case "ErrorOccured_ActionCancelled":
											_ErrorOccured_ActionCancelled = strMsgValue;
											break;
										case "FromDate_Greater_Todate":
											_FromDate_Greater_Todate = strMsgValue;
											break;
										case "Invalid_Date":
											_Invalid_Date = strMsgValue;
											break;
										case "Password_Changed_Successfully":
											_Password_Changed_Successfully = strMsgValue;
											break;
										case "PathNotFound":
											_PathNotFound = strMsgValue;
											break;
										case "CannotDelete_ReferenceExists":
											_CannotDelete_ReferenceExists = strMsgValue;
											break;
										case "Cart_Empty":
											_Cart_Empty = strMsgValue;
											break;
										case "Please_Enter":
											_Please_Enter = strMsgValue;
											break;
										case "Please_Select":
											_Please_Select = strMsgValue;
											break;
										case "EmailNotFound":
											_EmailNotFound = strMsgValue;
											break;
										case "EmailSent":
											_EmailSent = strMsgValue;
											break;
										case "IncorrectPwd":
											_IncorrectPwd = strMsgValue;
											break;
										case "Insert_EmailExists":
											_Insert_EmailExists = strMsgValue;
											break;
										case "ConfirmPwd_Must_Match":
											_ConfirmPwd_Must_Match = strMsgValue;
											break;
										case "Invalid_Email":
											_Invalid_Email = strMsgValue;
											break;
										case "SqlInjectionMsg":
											_SqlInjectionMsg = strMsgValue;
											break;
										case "SqlInjection_PwdLen":
											_SqlInjection_PwdLen = strMsgValue;
											break;
										case "SqlInjection_ConfirmPwdLen":
											_SqlInjection_ConfirmPwdLen=strMsgValue;
											break;
										case "AddEditUser_AccesRights":
											_AddEditUser_AccesRights = strMsgValue;
											break;
										case "AddEditUser_LastSuperAdmin":
											_AddEditUser_LastSuperAdmin = strMsgValue;
											break;
										case "Insert_UnitNoExists":
											_Insert_UnitNoExists = strMsgValue;
											break;
										case "Not_LoggedIn":
											_Not_LoggedIn = strMsgValue;
											break;
									}
								}
								i = i + 1;
							} while (nodeIter.Current.MoveToNext());
							nodeIter.Current.MoveToParent();
						}
					}

					break;
				case XPathResultType.Error:
					strOutput = "Error ";

					break;
			}
			return strOutput;
		}
		#endregion
		//
			// TODO: Add constructor logic here
			//
	}
}

