using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace Gryfo_GCM
{
	public static class Database
	{
		private static string path = AppDomain.CurrentDomain.BaseDirectory + @"projetogcm.json";

		public static FirestoreDb FirestoreDatabase { private set; get; }

		public static string ConnectToDatabase()
		{
			Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
			string message;
			try
			{
				FirestoreDatabase = FirestoreDb.Create("cloudfire-afac3");

				if(FirestoreDatabase != null)
				{
					message = "Connection established";
				}
				else
				{
					message = "Connection error";
				}
			}
			catch (Exception e)
			{
				return e.Message;
			}
			

			return message;
		}
	}
}
