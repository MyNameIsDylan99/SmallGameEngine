
#version 400 core
out vec4 FragColor;

in vec3 normal;
in vec3 position;

uniform vec3 cameraPos;
uniform samplerCube skybox;

void main()
{             
    vec3 I = normalize(position - cameraPos);
    vec3 R = reflect(I, normalize(normal));
    FragColor = vec4(texture(skybox, vec3(-R.x, R.y, R.z).rgb, 1.0));
}