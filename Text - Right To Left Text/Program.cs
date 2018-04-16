//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace RightToLeftText
{
	/// <summary>
	/// This example demonstrates how to draw right-to-left text.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add page
			Page page = new Page(PaperFormat.A4);
			pdfDocument.Pages.Add(page);

			Font font = new Font("Arial", 16);
			Brush brush = new SolidBrush();
			
			// Set right to left text direction
			StringFormat stringFormat = new StringFormat();
			stringFormat.DirectionRightToLeft = true;

			page.Canvas.DrawString("???? ????? ?????", font, brush, page.Width - 20, 30, stringFormat);
			page.Canvas.DrawString("???, ?????, ????", font, brush, page.Width - 20, 50, stringFormat);
			page.Canvas.DrawString("?? ?? ??", font, brush, page.Width - 20, 70, stringFormat);

			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
