# Genetic-Algorithm-Template  
Genetic Algorithm Template  

This is a simple to use genetic algorithm template. In order to use you simply create your problem class to meet the   
requirements set in the IProblem interface, (let's call it MyProblem). Then initialise as following.  

################ Reuired  
GeneticAlgorithm MyGA = new();    
MyGA.Set_Problem(new MyProblem);
  
  
############ Optional and modifyable at runtime  

MyGA.Set_AlwaysMutate(true);  
// ensures at least one mutation every mating  

MyGA.Set_MaximumAge(100);  
// sets a maximum age, this is to cause instability on local phenomena  

MyGA.Set_MutationOdds(2);  
// how likely a mutation is to happen (recursive) 1 = 2:1, 2 = 4:1, etc  

MyGA.Set_PopulationSize(16);  
// How big you want the population to be  

  
###############

MyGA.Start();  
// Starts the GA

MyGA.Stop();  
// Stops the GA, (at the end of the current generation for neatness.)


There are also a few events:  
E_GenerationComplete ... runs at the end of the generation and holds the generation number in the sender field.  
E_ImprovementFound ... runs every time there is a new best creature and returns (GeneString, NumberOfErrors) in the sender field.  
E_AlgorithmSuccessful ... runs if the GA completes and returns the GeneString of the winner in the sender field.
