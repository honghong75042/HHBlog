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
	//Personsetting
	///
	public interface IPersonsetting
	{
		 PersonsettingEntity SelectPersonsettingByID(int t_id);
		
		 IList<PersonsettingEntity> GetAllPersonsetting();
				
		 IList<PersonsettingEntity> GetAllPersonsettingByauthor_id(int t_author_id);
		
		 IList<PersonsettingEntity> GetAllPersonsettingBymodel_id(int t_model_id);
		
	
		  int InsertPersonsetting(PersonsettingEntity t_Personsetting);
		
		  int UpdatePersonsetting(PersonsettingEntity t_Personsetting);
		
		  int DeletePersonsetting(int t_id);
	}
}


