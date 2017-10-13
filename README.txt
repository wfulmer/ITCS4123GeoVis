Timothy Hayduk - 3D Map Layout, Chemical bar graph
Willis Fulmer - Interaction, VR Integration
Jesse Pinkston - Industry Sector bar graph (Unimplemented)

For our Device Starter, we decided to stick with the same data set from our Data Starter, 
which was the EPA Releases set.

We decided to use VR to create our visualization, using Unity to create a 3D map of the 48 contiguous
United States. This map was raised and colored based on the amount of releases in each state.

For interaction, we have allowed the user to look at and click on a state. This will bring up a bar
graph to the left of the states with the top 10 chemicals released in that state.

There are several Python scripts included in this repo used to manipulate the data. These scripts expect
a json file as their input, which we used an online csv-to-json converter to create.
 - StateHeights.py will generate a new json file containing the scaled height for each state
 - StateChemicals.py will generate a new json file containing the top 10 chemical names and values for 
   each state.

The 3D state sprites are currently generated using a script from the Unity Asset "2D Tilezone", which
allowed us to generate 3D walls from the 2D sprites.
https://www.assetstore.unity3d.com/en/#!/content/34147