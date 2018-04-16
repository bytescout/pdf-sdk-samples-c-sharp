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

namespace DisplayOptions
{
	/// <summary>
	/// This example demonstrates how to set display options for a viewer application.
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

			// Set page mode (which panels should be shown at viewing application start)
			pdfDocument.PageMode = PageMode.Thumbnail; // show thumbnails panel

			// Show/hide various interface elements
			pdfDocument.ViewerPreferences.CenterWindow = true;
			pdfDocument.ViewerPreferences.FitWindow = true;
			pdfDocument.ViewerPreferences.HideMenubar = true;
			pdfDocument.ViewerPreferences.HideToolbar = true;
			pdfDocument.ViewerPreferences.HideWindowUI = false;
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
