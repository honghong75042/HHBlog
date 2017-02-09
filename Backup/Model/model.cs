
///
//generate by CodeSmith
//created time:2010?1?24?
//Name:NN
///

using System;

namespace Blogo.Model
{
	public class ModelEntity
	{
		protected int _model_id;
		protected string _name = String.Empty;
		protected string _path = String.Empty;
	
		public ModelEntity()
		{
			
		}
		
		public ModelEntity(int model_id,string name,string path)
		{
			_model_id = model_id ;	
			_name = name ;	
			_path = path ;	
		}
		
		public int  Model_id
		{
			get
			{
				return _model_id;
			}
			set
			{
				_model_id=value;
			}				
		}
			
		public string  Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name=value;
			}				
		}
			
		public string  Path
		{
			get
			{
				return _path;
			}
			set
			{
				_path=value;
			}				
		}
			
	}
}


