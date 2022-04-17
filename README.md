# Genetic-Algorithm-Template  
Genetic Algorithm Template  

This is a simple to use genetic algorithm template. In order to use you simply create your problem class to meet the   
requirements set in the IProblem interface, (let's call it MyProblem). Then initialise as following.  

################ Reuired  
GeneticAlgorithm MyGA = new();    
MyGA.Set_Problem(new MyProblem);  
MyGA.Start();  
  
  
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

MyGA.Reset_GA()
// Reset the genenetic algorithm

MyGa.Get_Current_Best
// Gets the current best (worth) of the population

###############


MyGA.Stop();  
// Stops the GA, (at the end of the current generation for neatness.)


There are also a few events:  
E_GenerationComplete ... send the number of the generation  
E_ImprovementFound ... send the gene string of a new improvement  
E_AlgorithmSuccessful ... sends the genes of the winner
