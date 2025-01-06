# VR Walking Simulator

This is a a simple VR demo for Quest 2/3 with basic character interaction


# Download/Install

Go to the releases tab of this repo or download from [here](https://github.com/Fishybearr/VRDemo/releases/tag/ReleaseBuild2)

This will download an **APK** built for Meta Quest devices. [Here's a link](https://zybervr.com/blogs/news/step-by-step-guide-on-how-to-install-apk-files-on-meta-quest?srsltid=AfmBOoqLH8bR3lSui0X0xSGTDa3lsftaY8jrkxrYhX1pABrDk11nyly1) to an article on how to install APKs to the Quest if you're not familiar

The APK should show up on the device as **com.Fishybear.VRWalkingSim**

# Features

- Character eye, head, and body tracking
 - Dynamic blinking randomized between 1 and 4 seconds
 - Customizable notice distance for character
 - Idle state and animation
 - Animation speed scales with character size
 - Character head distance and rotation limits
 - Customizable character detection parameters
 - Resizable play field
 - Motion sickness prevention when resizing play field

# Settings Tutorial

   The settings menu in the demo allows the player to tweak many of the character tracking options
   
   **Below** is an explanation of these settings

   ## Standard Menu
   - **NPC Height:** resizes character
   - **Player Size:** resizes player
   - **Advanced NPC Detection Settings:** enables menu for advanced detection settings

   ## Advanced NPC Detection Menu
   - **Detection X Pos:** x position of detection sphere
   - **Detection Y Pos:** y position of detection sphere
   - **Detection Z Pos:** z position of detection sphere
   - **Detection Scale:** scale of detection sphere
   - **NPC Notice Distance:** distance away character will notice player
   - **Enable Debug View:** displays character detection sphere and raycast from center of player's vision
   - **Reset Transforms:** resets the detection sphere position and scale values


# Notes
## General
- I designed, tested on, and optimized this project for the Quest 2 so I assume all should work well on Quest 3. If you have any questions or issues with the build definitely reach out to me via [email](mailto:aaronrad@buffalo.edu)

- All of the character setting sliders allow you to fully break the simulation hence why they are in the debug menu

## Appearance 
- All of the models were made by myself with Blender and Fuse

- All of the textures used in this environment were created by myself in Photoshop or taken from [this](https://3dtextures.me/) royalty free website

- I also used [this](https://fontstruct.com/fontstructions/show/2548411/5x8-side) font for some of the signs on the train

- There is some artifacting on the shadows cast around the environment due to the limitations of baked lighting android on devices

## Technical
- All scene lighting is baked for performance  

- Scripts were optimized specifically to minimize memory use (as it is limited on Quest)

- All models are low poly and optimized for VR

- All textures are capped at 2k resolution to reduce system load

- All unnecessary assets were removed from build to reduce APK size 
