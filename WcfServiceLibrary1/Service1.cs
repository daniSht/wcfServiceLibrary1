using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private string GetRandomResponse(List<string> responseList)
        {
            var rnd = new Random();
            int listCount = responseList.Count();
            return responseList[rnd.Next(listCount)];
        }

        private bool InputMessageIs(List<List<string>> messageDescriptor, string inputMessage)
        {
            return messageDescriptor.Any(variation => variation.TrueForAll(word => inputMessage.ToLower().Contains(word)));
        }

        public string Respond(string inputMessage)
        {
            //throw new NotImplementedException();
            foreach(var inputResponsePair in MessageData.LstInputResponseData)
            {
                if(inputResponsePair.InputDescriptor != null)
                {
                    if(InputMessageIs(inputResponsePair.InputDescriptor, inputMessage))
                    {
                        return GetRandomResponse(inputResponsePair.ResponseVariations);
                    }
                }
            }
            return GetRandomResponse(MessageData.LstInputResponseData.FirstOrDefault(inputResponsePair => inputResponsePair.InputDescriptor == null).ResponseVariations);
        }
    }
}
