#version 400 core
layout (location = 0) in vec3 in_position;
layout (location = 1) in vec3 in_normal;

out vec3 normal;
out vec3 position;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat4 tangentToWorld;

void main()
{
    normal = normalize(mat3(tangentToWorld) * in_normal);
    position = vec3( model * vec4(in_position, 1.0));
    gl_Position = projection * view * vec4(position, 1.0);
}