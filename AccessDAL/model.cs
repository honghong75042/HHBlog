///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.OleDb;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;


namespace Blogo.AccessDAL
{
	///
	//Model
	///
	public class Model:IModel
	{
		public  ModelEntity SelectModelByID(int t_model_id)
		{
			ModelEntity t_Model=new ModelEntity();
			OleDbDataReader sdr =null;
			using(sdr=OLEDBHelp.GetReader("select * from Model where model_id="+t_model_id))
			{
				if(sdr.Read())
				{
					t_Model.Model_id=(int)sdr.GetValue(0);
					t_Model.Name=(string)sdr.GetValue(1);
					t_Model.Path=(string)sdr.GetValue(2);
					
				}
				
			}
			sdr.Close();
			
			return t_Model;
		}
		
		public IList<ModelEntity> GetAllModel()
		{
			IList<ModelEntity> t_Models=new List<ModelEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Model"))
			{
				while(sdr.Read())
				{
					ModelEntity t_Model=new ModelEntity();
					t_Model.Model_id=(int)sdr.GetValue(0);					
					t_Model.Name=(string)sdr.GetValue(1);					
					t_Model.Path=(string)sdr.GetValue(2);					
					t_Models.Add(t_Model);
				}
				sdr.Close();
			}
			
			return t_Models;
		}
		
	
		public  int InsertModel(ModelEntity t_Model)
		{			
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Model_id",t_Model.Model_id),					
				new OleDbParameter("@Name",t_Model.Name),					
				new OleDbParameter("@Path",t_Model.Path)				
				
			};
			
			int i=OLEDBHelp.GetExecute("insert into Model values(@Model_id,@Name,@Path)",p);
			return i;				
		}
		
		public  int UpdateModel(ModelEntity t_Model)
		{
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Model_id",t_Model.Model_id),					
				new OleDbParameter("@Name",t_Model.Name),					
				new OleDbParameter("@Path",t_Model.Path)				
				
			};
			
			int i=OLEDBHelp.GetExecute("update Model set name=@Name,path=@Path where model_id=@Model_id",p);
			return i;	
		}
		
		public  int DeleteModel(int t_model_id)
		{
			int i=OLEDBHelp.GetExecute("delete from Model where model_id="+t_model_id);
			return i;
		}
	}
}


