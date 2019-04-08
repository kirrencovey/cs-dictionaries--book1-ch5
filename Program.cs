using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main()
        {

            {// Practice 1: Stock Purchase Dictionaries
            // Instructions
            // A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            // Add a few more of your favorite stocks
            stocks.Add("ZOO", "The Zoo");
            stocks.Add("DOG", "Dogs R Us");

            // To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.

            string GM = stocks["GM"];
            // Next, create a list to hold stock purchases by an investor. The list will contain dictionaries.

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            // Then add some purchases.

            // Example
            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });

            // Add more purchases for each stock
            purchases.Add(new Dictionary<string, double>() { { "CAT", 325.90 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 376.28 } });
            purchases.Add(new Dictionary<string, double>() { { "ZOO", 986.54 } });
            purchases.Add(new Dictionary<string, double>() { { "DOG", 786.29 } });

            // Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock

                From the three purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

                Replace the questions marks below with the correct types.
            */
            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> transaction in purchase)
                {
                    string fullCompanyName = stocks[transaction.Key];
                    // Does the full company name key already exist in the `stockReport`?
                    if (stockReport.ContainsKey(fullCompanyName))
                    {
                        // If it does, update the total valuation
                        stockReport[fullCompanyName] += transaction.Value;

                    } else {
                        /*
                            If not, add the new key and set its value.
                            You have the value of "GE", so how can you look
                            the value of "GE" in the `stocks` dictionary
                            to get the value of "General Electric"?
                        */
                        stockReport.Add(fullCompanyName, transaction.Value);
                    }
                }
            }
            // Now that the report dictionary is populated, display the final results.

            foreach (KeyValuePair<string, double> item in stockReport)
            {
                // Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
            }
            }



            {// Practice 2: Iterating over planets
            // Now we'll combine Dictionaries with the Lists we learned in the previous chapter.
            // Instructions

            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};
                        // Create another list containing dictionaries.Each dictionary will hold the name of a spacecraft that we have launched, and the name of a planet that it has visited. The key of the dictionary will be the planet name, and the value will be the spacecraft.

            List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
                        // This would be the equivalent of an having an array of objects in JavaScript.
                        planetProbes.Add(new Dictionary<string, string>() { {"Mercury", "Mariner 10" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Mercury", "MESSENGER" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Venus", "Pioneer Venus Orbiter" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Venus", "Galileo" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Mars", "Curiosity" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Mars", "Insight" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Jupiter", "Juno" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Jupiter", "Europa Clipper" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Saturn", "Voyager 1" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Saturn", "Cassini" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Uranus", "Voyager 2" } });
                        planetProbes.Add(new Dictionary<string, string>() { {"Neptune", "Voyager 2" } });

            // Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

            // iterate planets
                    foreach (string planet in planetList)
                    {
                        List<string> matchingProbes = new List<string>();

                        foreach (Dictionary<string, string> probe in planetProbes) // iterate planetProbes
                        {
                            foreach (KeyValuePair<string, string> kvp in probe)
                            /*
                                Does the current Dictionary contain the key of
                                the current planet? Investigate the ContainsKey()
                                method on a Dictionary.

                                If so, add the current spacecraft to `matchingProbes`.
                            */
                            if (planet == kvp.Key) {
                                matchingProbes.Add(kvp.Value);
                            }
                        }

                        /*
                            Use String.Join(",", matchingProbes) as part of the
                            solution to get the output below. It's the C# way of
                            writing `array.join(",")` in JavaScript.
                        */
                        // Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                    }
            }


        {// Lightning Exercise 1:

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();

            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                // Console.WriteLine($"{idiom.Key}: {String.Join(" ", idiom.Value)}");
            }

        }

        {// Lightning Exercise 2:
            // Ariana's boyfriends
                // Pete Davidson
                // Ricky Alvarez
                // Big Sean
                // Jai Brooks
                // Nathan Sykes
                // Graham Phillips

                Dictionary<string, string> boyfriends = new Dictionary<string, string>();

                // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}
                boyfriends.Add("Pete Davidson", "boyfriend");
                boyfriends.Add("Ricky Alvarez", "boyfriend");
                boyfriends.Add("Big Sean", "boyfriend");
                boyfriends.Add("Jai Brooks", "boyfriend");
                boyfriends.Add("Nathan Sykes", "boyfriend");
                boyfriends.Add("Graham Phillips", "boyfriend");

                // I want you to change the value boyfriend to ex-boyfriend ex {Big Sean, ex-boyfriend}, if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}

                // Make a new dictionary to store the updated values in
                Dictionary<string, string> updatedBoyfriends = new Dictionary<string, string>();

                foreach (KeyValuePair<string, string> boyfriend in boyfriends)
                {
                    if (boyfriend.Key == "Pete Davidson") {
                        updatedBoyfriends[boyfriend.Key] = "ex-fiance";
                    } else {
                        updatedBoyfriends[boyfriend.Key] = "ex-boyfriend";
                    }
                }

                // display the results "Ariana's {value} is {key}"
                foreach (KeyValuePair<string, string> boyfriend in updatedBoyfriends)
                {
                    // Console.WriteLine($"Ariana's {boyfriend.Value} is {boyfriend.Key}");
                }
        }

        {// Lightning Exercise 3:
        // create a dictionary with key value pairs to represent words (key) and its definition (value) 
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");
            wordsAndDefinitions.Add("Goose", "A large duck-like bird");
            wordsAndDefinitions.Add("Nap", "Great way to spend an afternoon");
            wordsAndDefinitions.Add("Snack", "Something delicious");

            // use square bracket lookup to get the definition of a specific word

            Console.WriteLine(wordsAndDefinitions["Goose"]);

            // loop over dictionary to get the following output: "The definition of [WORD] is [DEFINITION]"
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                // Console.WriteLine($"The definition of {word.Key} is: '{word.Value}'");
            }

        }
        }
    }
}
