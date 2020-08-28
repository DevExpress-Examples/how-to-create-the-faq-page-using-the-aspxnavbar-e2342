<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxNavBar" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>How to create the FAQ Page using the ASPxNavBar</title>
	<style type="text/css">
		.heading {
			font-size: large;
			color: Blue;
		}

		.Question {
			color: Gray;
			font-size: 11pt;
		}

			.Question img {
				vertical-align: middle;
			}

			.Question span {
				vertical-align: middle !important;
			}

		.Answer {
			font-size: 11pt;
			padding-left: 35px !important;
			padding-top: 8px;
			padding-bottom: 8px;
		}

		.defaultStyle {
			padding-left: 0px;
			list-style-type: none;
			margin: 0px;
		}
		.groupPadding {
			padding-left:0px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div style="min-height: 500px;">
			<div class="heading">
				Frequently Asked Questions
			</div>
			<div style="padding-left: 10px; padding-top: 10px;">
				<dx:ASPxNavBar ID="navFAQ" runat="server" ExpandButtonPosition="Left"
					AutoCollapse="True" GroupSpacing="5px" EncodeHtml="False" CssPostfix="None" CssClass="defaultStyle">
					<GroupHeaderStyle CssClass="Question" ImageSpacing="8px">
					</GroupHeaderStyle>
					<CollapseImage Url="~/Images/nbCollapse.png">
					</CollapseImage>
					<ExpandImage Url="~/Images/nbExpand.png">
					</ExpandImage>
					<ItemStyle CssClass="Answer defaultStyle" />
					<GroupContentStyle CssClass="groupPadding"></GroupContentStyle>
				</dx:ASPxNavBar>
			</div>
		</div>
	</form>
</body>
</html>
