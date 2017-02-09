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


namespace Blogo.IDAL
{
	///
	//Model
	///
	public interface IModel
	{
		 ModelEntity SelectModelByID(int t_model_id);
		
		 IList<ModelEntity> GetAllModel();
				
	
		  int InsertModel(ModelEntity t_Model);
		
		  int UpdateModel(ModelEntity t_Model);
		
		  int DeleteModel(int t_model_id);
	}
}


