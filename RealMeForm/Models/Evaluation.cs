using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealMeForm.Models
{
    public class Evaluation
    {
        [JsonProperty(PropertyName = "idEvaluation")]
        Guid idEvaluation;
        [JsonProperty(PropertyName = "idmetteur")]
        String idEmetteur;
        [JsonProperty(PropertyName = "firstName")]
        String firstName;
        [JsonProperty(PropertyName = "lastName")]
        String lastName;
        [JsonProperty(PropertyName = "mirror")]
        String mirror;
        [JsonProperty(PropertyName = "group")]
        String group;
        [JsonProperty(PropertyName = "critere")]
        String critere;
        [JsonProperty(PropertyName = "note")]
        int note;

        public Evaluation()
        {
        }

        public Evaluation(string idEmetteur, string firstName, string lastName, string mirror, string group, string critere, int note)
        {
            
            this.idEvaluation = Guid.NewGuid();
            this.idEmetteur = idEmetteur;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mirror = mirror;
            this.group = group;
            this.critere = critere;
            this.note = note;
        }
    }
}