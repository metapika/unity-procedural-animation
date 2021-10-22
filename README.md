# Unity Spider/Bug Procedural Animation
A procedural animation movement system made for bugs and other spider-like creatures.

Project made in Unity 2020.3.10f1

# Installing
Clone the repository with

``git clone https://github.com/metapika/unity-procedural-animation`` 

in cmd (Windows) / terminal(Linux/Mac) or download the repository

Open the project with Unity 2020.3.10f1.

# Usage
In 'Sample Scene' (located in ``Assets/Scenes``) you can see 2 main GameObjects: DestinationSetter and Spider_Procedural. DestinationSetter is a basic script that allows you to click anywhere on the ground plane and make the Spider's NavMesh agent change it's destonation there.

**Spider_Procedural Hierarchy:**

![Spider_Procedural_Hierarchy](https://i.imgur.com/atmTEDH.png)

The Spider has a ``SpiderGFX`` which is the [Spider Orange Model](https://assetstore.unity.com/packages/3d/characters/robots/spider-orange-181154) with Unity's Animation Rigging Package ``Bone Renderer`` Component on it to visualize all the bones. A child of the GFX is an object named ``Rig1`` that is a parent of all the legs' respective targets and hints. Each target has a ``IKFootSolver`` script on it, which allows the IK target to move procedurally.

To use this script with your own model in another project, i suggest taking these steps:
- Recreate the hierarchy for better IK target management. So create a ``Rig`` and parent it to the model;
- Add respective amount of leg objects to the ``Rig`` object and add the ``IKFootSolver`` script to each target. Also create a Hint object for all of the children;

![Spider_Procedural_Legs](https://i.imgur.com/28EddMG.png)
- Set up the ``Other Foot`` variable like shown in the image below;

![Spider_Procedural_Vars](https://i.imgur.com/VZWY7Kj.png)

- Select the body (or a piece that is roughly in the center of the model) and set it to the ``Body`` variable;
- Select all of the layers that are used as layers you use for ground objects

You are ready to use procedural animation. It may look janky or not work at all, thats why you should check out the ``Setting up / Tweaking`` section

# Setting up / Tweaking

- ``Speed`` - Tweak it to your liking. Make sure to manage your goal of the speed that the model is going to be moving at. I found that 15 is an optimal speed for pretty fast enemies yet not too fast for the movement to not be noticable.
  - ``Lerp Target`` - A very important variable that you will need to change all the time when setting up your model. I found that it's best to set it to `to 1 when the speed is smaller than 7` and `1.1 when the speed is 7 or more`
- ``Step Distance`` - You will need to experiment a bit and get to know the limiting distance of your legs.
- ``Overhead Amount`` - DO NOT set it higher than or equal to the ``Step Distance``. If you do, the leg will move forward and backwards endlessly. If you want to really go all in, set it to `the Step Distance minus 0.5`, but i personally reccomend setting it around ``the Step Distance minus 0.15`` for the two faster legs and then `minus 0.5` for the other two legs.
- ``Step Height`` - No explanation here. Just the height the leg will travel on the curve between points.

# Packages I've used
- Unity's Animation Rigging (Bone visualization)
- [FastIK](https://assetstore.unity.com/packages/tools/animation/fast-ik-139972) (Spider's legs are based on IK)

# Additional Packages
- [Spider Orange Model](https://assetstore.unity.com/packages/3d/characters/robots/spider-orange-181154) (Preview Model)
- [Nav Mesh Components (For spider's movement preview)](https://github.com/Unity-Technologies/NavMeshComponents)

# Licensing etc.
You can use any of this project's scripts (that is the ones that i wrote) in personal or commerical use. You don't need to credit me, but it would be cool if you did.

