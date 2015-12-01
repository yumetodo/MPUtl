## Principles
1. Simple and intuitive (i.e. No Adobe layout)
2. Easy for existing AviUtl users to adapt
3. Not too difficult for users coming from other simple video-editing software
4. Flexible

## Existing UI deficiency
1. Plugin list can be way too long
2. MOST of the AviUtl new users cannot retrieve back the NLE panel after closing it
3. Profile workflow is not so intuitive
4. No multi-segment selection
5. Many users unaware of the importance of Filter Order
6. Each plugin can only be invoked once by user
7. Plugin setting dialog is minimalistic, and get elongated when too many controls set on it
8. Layer 1 should be at the bottom, while layer 1+N should be on top. Matching most of the CG software convention

## UI Layout description
(with reference to ``DesignConcept01.png``)

### Panel 1
* Main Window
* Coordinate system same as AviUtl
* Panel extension/retraction buttons on the 3 edges (purple 7)
* Move Decoder/Encoder options visible at top menu since these are frequently accessed. Items include "Type", "Priority", "Details"
* Selection_Mode: "Single" and "Multi" option. "Single" behaves like AviUtl, "Multi" allows multiple segment selection by pressing the bracket keys multiple times.For example: ``[→→]→→→[→]`` would select 2 segments instead of one
* Playback: The usual Play/Stop/Loop
* Any file loaded via D&D on to the main Window, should be showing up in the NLE panel(3) special track "BG"
* Showing oversized image: Let user to choose "Fit to window" or "Partial(or a magnification)", never expand the window automatically as that may make subsequent operation difficult, e.g. a 4K video showing on a FullHD display: all other panels will be pushed out of screen

### Panel 2
* Multi-purpose panel
* Content can be changed via "panel_type" menu
* Reserves for Side-by-Side(SBS) preview, NLE and Audio Mixer
* If it is not set for SBS or retracted, preview carry out in Main Window
* If it is set for SBS and visible, Main Window plays the original, this panel plays the processed image
* Different timing/length from original video: (To be discussed)

### Panel 3
* Multi-purpose panel
* For NLE or Audio Mixer
* Introduce two special tracks: BG and Profile
* BG represents the file loaded via D&D-ing on to the Main Window
* Should BG be broken into Audio and Video tracks? (To be discussed)
* Profile represents the application of Plugin-setting collectives
* Layer 1 comes next, higher Layer No. on top.

### Panel 4
* Filter Graph
* Somewhat similar to ExEdit's object's panel. User can choose to use a plugin by pressing the + button on top right, browse through categories, and select the desired plugin
* Categorization is a MUST or the plugin list will get out-of-control. Optionally add a search box in (6) to speed up operation
* Each item in Filter graph should provide buttons to move its priority, show its setting dialog (5) and a switch to quickly turn it ON and OFF
* Tabbed, dividing Video Filter Graph and Audio Filter Graph
* There should be a button(and optionally a textbox), for each tab, for saving plugin configurations into a profile. The profiles should be accessible from the NLE's Profile track.

### Panel 5
* Plugin property window
* Floating/Fixed ? (To be discussed)
* Basically the same as the AviUtl plugin interface
* Need to support TAB to better organize controls
* Having an easy way to add ComboListBox, textbox and Tooltips would be nice
* WkmUtl must provide language info to plugin so that plugin i18n would be easier

### Other thoughts
* Maybe it is possible to disband the idea of "default image data structure"
* Instead of requiring each plugin to convert image to YC48 by the end of processing, just require plugins to specify what they expect to be the input, and what they output. It may be even better to require plugins to declare where they intend to take image data from: from file, from System RAM, or from Video Memory.
* Automatic format conversion can be carried out when there is a IO-type mismatch between two consecutive items in the filter graph
* The final image format depends on what is easy for the rendering/output facilities.
