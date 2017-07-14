using System.Collections.Generic;

namespace WcfServiceTest
{
    public class InputResponsePair
    {
        public InputResponsePair(List<string> responseVariations)
        {
            Name = "Default";
            InputDescriptor = null;
            ResponseVariations = responseVariations;
        }
        public InputResponsePair(List<List<string>> inputDescriptor, List<string> responseVariations)
        {
            Name = null;
            InputDescriptor = inputDescriptor;
            ResponseVariations = responseVariations;
        }
        public InputResponsePair(string name, List<List<string>> inputDescriptor, List<string> responseVariations)
        {
            Name = name;
            InputDescriptor = inputDescriptor;
            ResponseVariations = responseVariations;
        }
        public string Name { get; set; }
        public List<List<string>> InputDescriptor { get; set; }
        public List<string> ResponseVariations { get; set; }
    }

    public class InputDescriptors
    {
        public static readonly List<List<string>> Hello = new List<List<string>>
        {
            new List<string> { "hello" },
            new List<string> { "hi" }
        };

        public static readonly List<List<string>> Name = new List<List<string>>
        {
            new List<string> { "what", "name", "your" },
            new List<string> { "what", "call", "you" }
        };

        public static readonly List<List<string>> Nice = new List<List<string>>
        {
            new List<string> { "nice" },
            new List<string> { "great" },
            new List<string> { "awesome" },
            new List<string> { "cool" }
        };

        public static readonly List<List<string>> Status = new List<List<string>>
        {
            new List<string> { "how", "you" },
            new List<string> { "what", "up" }
        };

        public static readonly List<List<string>> Type = new List<List<string>>
        {
            new List<string> { "what", "are", "you" },
            new List<string> { "what", "i", "talking" }
        };

        public static readonly List<List<string>> Music = new List<List<string>>
        {
            new List<string> { "what", "listen", "you" },
            new List<string> { "what", "music", "you", "like" },
            new List<string> { "what", "music", "you", "prefer" },
            new List<string> { "what", "favourite", "your", "music" },
            new List<string> { "what", "favourite", "your", "genre" }
        };
    }

    public class Responses
    {
        public static readonly List<string> Default = new List<string>
        {
            "Sorry, I didn't understand you.",
            "What?",
            "Come again?",
            "I am too stupid to understand you.",
            "I've got nothing."
        };

        public static readonly List<string> Hello = new List<string>
        {
            "Hello there!",
            "Hi there!",
            "Hello!",
            "Hi!"
        };

        public static readonly List<string> Status = new List<string>
        {
            "I am functioning within the established parameters!",
            "I am well thank you!",
            "I am fine!",
            "I am peaches!"
        };

        public static readonly List<string> Name = new List<string>
        {
            "My name is Botterrr.",
            "I'm called Botterrr.",
            "I'm Botterrr."
        };

        public static readonly List<string> Nice = new List<string>
        {
            "Ain't it?",
            "You betcha!",
            "Happy to serve!"
        };

        public static readonly List<string> Type = new List<string>
        {
            "I am a service.",
            "I am an AI.",
            "I am an android.",
        };

        public static readonly List<string> Music = new List<string>
        {
            "I like electronic music.",
            "I listen to electronic music.",
            "I enjoy electronic music.",
        };
    }

    public class MessageData
    {
        public static readonly List<InputResponsePair> LstInputResponseData = new List<InputResponsePair>()
        {
            new InputResponsePair(Responses.Default),
            new InputResponsePair("Hello", InputDescriptors.Hello, Responses.Hello),
            new InputResponsePair("Name", InputDescriptors.Name, Responses.Name),
            new InputResponsePair("Nice", InputDescriptors.Nice, Responses.Nice),
            new InputResponsePair("Status", InputDescriptors.Status, Responses.Status),
            new InputResponsePair("Type", InputDescriptors.Type, Responses.Type),
            new InputResponsePair("Music", InputDescriptors.Music, Responses.Music)
        };
    }
}
