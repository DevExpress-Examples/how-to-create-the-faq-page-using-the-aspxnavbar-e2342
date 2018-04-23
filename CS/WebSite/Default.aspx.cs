using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using DevExpress.Web.ASPxNavBar;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, System.EventArgs e)
	{
		if (!IsPostBack) {
			Load_FAQ();
		}
	}

	public void Load_FAQ()
	{
		string SQL = "SELECT [Sort], [Question], [Answer] FROM [FAQ] ORDER BY [Sort], [Question]";
		string Question = null;
		string Answer = null;
		int i = 0;
		OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB_Conn_FAQ"].ConnectionString);
		OleDbCommand SelectCommand = new OleDbCommand(SQL, conn);
		try {
			conn.Open();
			OleDbDataReader Reader = SelectCommand.ExecuteReader();
			while (Reader.Read()) {
				if (Reader.HasRows) {
					Question = Reader["Question"].ToString();
					Answer = Reader["Answer"].ToString();
					navFAQ.Groups.Add(Question);
					navFAQ.Groups[i].Items.Add(Answer);
				}
				i += 1;
			}
		} catch (Exception ex) {
		} finally {
			conn.Close();
			conn.Dispose();
			SelectCommand.Dispose();
		}
	}
}
