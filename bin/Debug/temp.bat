CD "C:\Program Files\ShaderMap CL 1.1.1"
START /WAIT shadermap.exe cdiff "D:\Photos\Images\1024768.bmp" -disp (40,100,20,*) -norm (51,100,*,*) -spec (54,100,100,*) -v
START /WAIT shadermap.exe 3dprv -diff ("D:\Photos\Images\1024768.bmp") -norm ("D:\Photos\Images\1024768_NORM.tga") -spec ("D:\Photos\Images\1024768_SPEC.bmp") -disp ("D:\Photos\Images\1024768_DISP.bmp")
 -v