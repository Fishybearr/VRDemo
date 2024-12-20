# VR Walking Simulator

This is a a simple VR demo for Quest 2/3 with basic character interaction


# Download/Install

Go to the releases tab of this repo or download from [here](https://github.com/Fishybearr/VRDemo/releases)

This will download an **APK** built for Meta Quest devices. [Here's a link](https://zybervr.com/blogs/news/step-by-step-guide-on-how-to-install-apk-files-on-meta-quest?srsltid=AfmBOoqLH8bR3lSui0X0xSGTDa3lsftaY8jrkxrYhX1pABrDk11nyly1) to an article on how to install APKs to the Quest if you're not familiar

# Features

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

   Until Wednesday I didn't own a VR headset. So I spent the majority of development on this project using Unity's built in VR simulator which provided its own very interesting set of problems

   If you have any questions or issues with the build definitely reach out to me via email
