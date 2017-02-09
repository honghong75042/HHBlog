///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;

using Blogo.SQLServerDAL;
using Blogo.AccessDAL;
using Blogo.DALFactory;



namespace Blogo.BLL
{
	///
	//Model
	///
	public static class ModelManager
	{
		private static Blogo.IDAL.IModel dal=Blogo.DALFactory.DataAccess.CreateModel();
		
		public static  ModelEntity SelectModelByID(int t_model_id)
		{
			ModelEntity temp=null;
			try
			{
				temp=dal.SelectModelByID( t_model_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<ModelEntity> GetAllModel()
		{
			IList<ModelEntity> temp=null;
			try
			{
				temp=GetAllModel();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
	
		public  static int InsertModel(ModelEntity t_Model)
		{		
			int i=-1;
			try
			{
				i=InsertModel(t_Model);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateModel(ModelEntity t_Model)
		{
			int i=-1;
			try
			{
				i=UpdateModel(t_Model);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteModel(int t_model_id)
		{
			int i=-1;
			try
			{
				i=DeleteModel(t_model_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


