using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace gui.Resources
{
    public class SceneVariables
    {
        public int n_runs { get; set; }
        public int groups { get; set; }
        public string df_name { get; set; }
        public string scene_script_name { get; set; }
        public string scene_id { get; set; }
        public IDictionary<string, bool> unique_columns { get; set; }      
        public static void createFile(SceneVariables sceneVariables, string fileName)
        {
            string jsonString = JsonConvert.SerializeObject(sceneVariables);
            File.WriteAllText(fileName, jsonString);
        }  
    }
    
}
