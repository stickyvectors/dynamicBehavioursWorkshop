# Creating Dynamic Behaviours In Unity - Workshop Materials
**An example project from the Creating Dynamic Behaviour in Unity workshop**

I have tidied up the project a little and added some of the things we only touched upon briefly at the end. I have also added some materials to a couple of things, have a go at changing them, add your own textures and play with the sliders in the Inspector panel! Don't be shy to experiment with the scripts either, add them to different things, mix them together, edit them, break them! Worst case scenario, you have to just download this repo again ¯\_(ツ)_/¯

If you're feeling extra adventurous you could also have a go at replacing the default cubes that make up our characters with imported models (.FBX / .OBJ work best). Remember how we set up all the scripts and behaviours on empty parent objects? This is why! You should just be able to import an object and drag it into the empty parent via the Heirarchy panel. There are plenty of tutorials on YouTube for how to import objects :)

**See here for a quick run-down of what I've changed**

* Added a few more obstacles
* Create some child lights for the eyes of our player, see how they copy the rotation of the parent?
* Stacked the 'bob' script onto our **PatrolTadpole's** child, **Tadpole** to make it look a bit more floaty!
* Added the spin script to the child capsule object of our **Pet** and added some planets that rotate it. This is done by making use of how rotating the parent empty, **PlanetGroup** will rotate child objects _around its own center, not that of the child object_. 
* Created a group of characters that try and follow each other: check out **PatrollingEachOther** group. This is done by using the same patrol script for the **Tadpole** but setting the patrol points to be that of the other **SadSausages**. Notice how I bumped the radius property of their NavMeshAgent components up to make them behave in a slightly more interesting/strange way.

That's about all :)
