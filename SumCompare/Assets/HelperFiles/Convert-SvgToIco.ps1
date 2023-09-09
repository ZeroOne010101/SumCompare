# This Powershell File relies on Imagemagick  and Inkscape to convert .svg files to the .ico format
# Pipe to Out-Null to wait for process to finish
inkscape ..\logo.svg -w 256 -h 256 -o logo-256.png | Out-Null
inkscape ..\logo.svg -w 128 -h 128 -o logo-128.png | Out-Null
inkscape ..\logo.svg -w 96 -h 96 -o logo-96.png | Out-Null
inkscape ..\logo.svg -w 64 -h 64 -o logo-64.png | Out-Null
inkscape ..\logo.svg -w 48 -h 48 -o logo-48.png | Out-Null
inkscape ..\logo.svg -w 32 -h 32 -o logo-32.png | Out-Null
inkscape ..\logo.svg -w 16 -h 16 -o logo-16.png | Out-Null
convert logo-256.png logo-128.png logo-96.png logo-64.png logo-48.png logo-32.png icon.ico