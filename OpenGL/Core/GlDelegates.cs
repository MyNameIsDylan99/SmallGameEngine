using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649

namespace OpenGL
{
    // Automatically generated from GlCore.cs using BuildGl
    public partial class Gl
    {
        internal static partial class Delegates
        {
            internal delegate void ActiveShaderProgram(UInt32 pipeline, UInt32 program);

            internal static ActiveShaderProgram glActiveShaderProgram;

            internal delegate void ActiveTexture(Int32 texture);

            internal static ActiveTexture glActiveTexture;

            internal delegate void AttachShader(UInt32 program, UInt32 shader);

            internal static AttachShader glAttachShader;

            internal delegate void BeginConditionalRender(UInt32 id, OpenGL.ConditionalRenderType mode);

            internal static BeginConditionalRender glBeginConditionalRender;

            internal delegate void EndConditionalRender();

            internal static EndConditionalRender glEndConditionalRender;

            internal delegate void BeginQuery(OpenGL.QueryTarget target, UInt32 id);

            internal static BeginQuery glBeginQuery;

            internal delegate void EndQuery(OpenGL.QueryTarget target);

            internal static EndQuery glEndQuery;

            internal delegate void BeginQueryIndexed(OpenGL.QueryTarget target, UInt32 index, UInt32 id);

            internal static BeginQueryIndexed glBeginQueryIndexed;

            internal delegate void EndQueryIndexed(OpenGL.QueryTarget target, UInt32 index);

            internal static EndQueryIndexed glEndQueryIndexed;

            internal delegate void BeginTransformFeedback(OpenGL.BeginFeedbackMode primitiveMode);

            internal static BeginTransformFeedback glBeginTransformFeedback;

            internal delegate void EndTransformFeedback();

            internal static EndTransformFeedback glEndTransformFeedback;

            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);

            internal static BindAttribLocation glBindAttribLocation;

            internal delegate void BindBuffer(OpenGL.BufferTarget target, UInt32 buffer);

            internal static BindBuffer glBindBuffer;

            internal delegate void BindBufferBase(OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);

            internal static BindBufferBase glBindBufferBase;

            internal delegate void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);

            internal static BindBufferRange glBindBufferRange;

            internal delegate void BindBuffersBase(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers);

            internal static BindBuffersBase glBindBuffersBase;

            internal delegate void BindBuffersRange(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes);

            internal static BindBuffersRange glBindBuffersRange;

            internal delegate void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name);

            internal static BindFragDataLocation glBindFragDataLocation;

            internal delegate void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;

            internal delegate void BindFramebuffer(OpenGL.FramebufferTarget target, UInt32 framebuffer);

            internal static BindFramebuffer glBindFramebuffer;

            internal delegate void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, OpenGL.BufferAccess access, OpenGL.PixelInternalFormat format);

            internal static BindImageTexture glBindImageTexture;

            internal delegate void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures);

            internal static BindImageTextures glBindImageTextures;

            internal delegate void BindProgramPipeline(UInt32 pipeline);

            internal static BindProgramPipeline glBindProgramPipeline;

            internal delegate void BindRenderbuffer(OpenGL.RenderbufferTarget target, UInt32 renderbuffer);

            internal static BindRenderbuffer glBindRenderbuffer;

            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);

            internal static BindSampler glBindSampler;

            internal delegate void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers);

            internal static BindSamplers glBindSamplers;

            internal delegate void BindTexture(OpenGL.TextureTarget target, UInt32 texture);

            internal static BindTexture glBindTexture;

            internal delegate void BindTextures(UInt32 first, Int32 count, UInt32[] textures);

            internal static BindTextures glBindTextures;

            internal delegate void BindTextureUnit(UInt32 unit, UInt32 texture);

            internal static BindTextureUnit glBindTextureUnit;

            internal delegate void BindTransformFeedback(OpenGL.NvTransformFeedback2 target, UInt32 id);

            internal static BindTransformFeedback glBindTransformFeedback;

            internal delegate void BindVertexArray(UInt32 array);

            internal static BindVertexArray glBindVertexArray;

            internal delegate void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride);

            internal static BindVertexBuffer glBindVertexBuffer;

            internal delegate void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

            internal static VertexArrayVertexBuffer glVertexArrayVertexBuffer;

            internal delegate void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);

            internal static BindVertexBuffers glBindVertexBuffers;

            internal delegate void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);

            internal static VertexArrayVertexBuffers glVertexArrayVertexBuffers;

            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);

            internal static BlendColor glBlendColor;

            internal delegate void BlendEquation(OpenGL.BlendEquationMode mode);

            internal static BlendEquation glBlendEquation;

            internal delegate void BlendEquationi(UInt32 buf, OpenGL.BlendEquationMode mode);

            internal static BlendEquationi glBlendEquationi;

            internal delegate void BlendEquationSeparate(OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);

            internal static BlendEquationSeparate glBlendEquationSeparate;

            internal delegate void BlendEquationSeparatei(UInt32 buf, OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);

            internal static BlendEquationSeparatei glBlendEquationSeparatei;

            internal delegate void BlendFunc(OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);

            internal static BlendFunc glBlendFunc;

            internal delegate void BlendFunci(UInt32 buf, OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);

            internal static BlendFunci glBlendFunci;

            internal delegate void BlendFuncSeparate(OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);

            internal static BlendFuncSeparate glBlendFuncSeparate;

            internal delegate void BlendFuncSeparatei(UInt32 buf, OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);

            internal static BlendFuncSeparatei glBlendFuncSeparatei;

            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);

            internal static BlitFramebuffer glBlitFramebuffer;

            internal delegate void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);

            internal static BlitNamedFramebuffer glBlitNamedFramebuffer;

            internal delegate void BufferData(OpenGL.BufferTarget target, IntPtr size, IntPtr data, OpenGL.BufferUsageHint usage);

            internal static BufferData glBufferData;

            internal delegate void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, OpenGL.BufferUsageHint usage);

            internal static NamedBufferData glNamedBufferData;

            internal delegate void BufferStorage(OpenGL.BufferTarget target, IntPtr size, IntPtr data, UInt32 flags);

            internal static BufferStorage glBufferStorage;

            internal delegate void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags);

            internal static NamedBufferStorage glNamedBufferStorage;

            internal delegate void BufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);

            internal static BufferSubData glBufferSubData;

            internal delegate void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data);

            internal static NamedBufferSubData glNamedBufferSubData;

            internal delegate OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenGL.FramebufferTarget target);

            internal static CheckFramebufferStatus glCheckFramebufferStatus;

            internal delegate OpenGL.FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, OpenGL.FramebufferTarget target);

            internal static CheckNamedFramebufferStatus glCheckNamedFramebufferStatus;

            internal delegate void ClampColor(OpenGL.ClampColorTarget target, OpenGL.ClampColorMode clamp);

            internal static ClampColor glClampColor;

            internal delegate void Clear(OpenGL.ClearBufferMask mask);

            internal static Clear glClear;

            internal delegate void ClearBufferiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);

            internal static ClearBufferiv glClearBufferiv;

            internal delegate void ClearBufferuiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);

            internal static ClearBufferuiv glClearBufferuiv;

            internal delegate void ClearBufferfv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);

            internal static ClearBufferfv glClearBufferfv;

            internal delegate void ClearBufferfi(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);

            internal static ClearBufferfi glClearBufferfi;

            internal delegate void ClearNamedFramebufferiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);

            internal static ClearNamedFramebufferiv glClearNamedFramebufferiv;

            internal delegate void ClearNamedFramebufferuiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);

            internal static ClearNamedFramebufferuiv glClearNamedFramebufferuiv;

            internal delegate void ClearNamedFramebufferfv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);

            internal static ClearNamedFramebufferfv glClearNamedFramebufferfv;

            internal delegate void ClearNamedFramebufferfi(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);

            internal static ClearNamedFramebufferfi glClearNamedFramebufferfi;

            internal delegate void ClearBufferData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearBufferData glClearBufferData;

            internal delegate void ClearNamedBufferData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearNamedBufferData glClearNamedBufferData;

            internal delegate void ClearBufferSubData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearBufferSubData glClearBufferSubData;

            internal delegate void ClearNamedBufferSubData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, Int32 size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearNamedBufferSubData glClearNamedBufferSubData;

            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);

            internal static ClearColor glClearColor;

            internal delegate void ClearDepth(Double depth);

            internal static ClearDepth glClearDepth;

            internal delegate void ClearDepthf(Single depth);

            internal static ClearDepthf glClearDepthf;

            internal delegate void ClearStencil(Int32 s);

            internal static ClearStencil glClearStencil;

            internal delegate void ClearTexImage(UInt32 texture, Int32 level, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearTexImage glClearTexImage;

            internal delegate void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);

            internal static ClearTexSubImage glClearTexSubImage;

            internal delegate OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

            internal static ClientWaitSync glClientWaitSync;

            internal delegate void ClipControl(OpenGL.ClipControlOrigin origin, OpenGL.ClipControlDepth depth);

            internal static ClipControl glClipControl;

            internal delegate void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);

            internal static ColorMask glColorMask;

            internal delegate void ColorMaski(UInt32 buf, Boolean red, Boolean green, Boolean blue, Boolean alpha);

            internal static ColorMaski glColorMaski;

            internal delegate void CompileShader(UInt32 shader);

            internal static CompileShader glCompileShader;

            internal delegate void CompressedTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

            internal static CompressedTexImage1D glCompressedTexImage1D;

            internal delegate void CompressedTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

            internal static CompressedTexImage2D glCompressedTexImage2D;

            internal delegate void CompressedTexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

            internal static CompressedTexImage3D glCompressedTexImage3D;

            internal delegate void CompressedTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;

            internal delegate void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTextureSubImage1D glCompressedTextureSubImage1D;

            internal delegate void CompressedTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;

            internal delegate void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTextureSubImage2D glCompressedTextureSubImage2D;

            internal delegate void CompressedTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;

            internal delegate void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);

            internal static CompressedTextureSubImage3D glCompressedTextureSubImage3D;

            internal delegate void CopyBufferSubData(OpenGL.BufferTarget readTarget, OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

            internal static CopyBufferSubData glCopyBufferSubData;

            internal delegate void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size);

            internal static CopyNamedBufferSubData glCopyNamedBufferSubData;

            internal delegate void CopyImageSubData(UInt32 srcName, OpenGL.BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenGL.BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

            internal static CopyImageSubData glCopyImageSubData;

            internal delegate void CopyTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border);

            internal static CopyTexImage1D glCopyTexImage1D;

            internal delegate void CopyTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

            internal static CopyTexImage2D glCopyTexImage2D;

            internal delegate void CopyTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

            internal static CopyTexSubImage1D glCopyTexSubImage1D;

            internal delegate void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

            internal static CopyTextureSubImage1D glCopyTextureSubImage1D;

            internal delegate void CopyTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static CopyTexSubImage2D glCopyTexSubImage2D;

            internal delegate void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static CopyTextureSubImage2D glCopyTextureSubImage2D;

            internal delegate void CopyTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static CopyTexSubImage3D glCopyTexSubImage3D;

            internal delegate void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static CopyTextureSubImage3D glCopyTextureSubImage3D;

            internal delegate void CreateBuffers(Int32 n, UInt32[] buffers);

            internal static CreateBuffers glCreateBuffers;

            internal delegate void CreateFramebuffers(Int32 n, UInt32[] ids);

            internal static CreateFramebuffers glCreateFramebuffers;

            internal delegate UInt32 CreateProgram();

            internal static CreateProgram glCreateProgram;

            internal delegate void CreateProgramPipelines(Int32 n, UInt32[] pipelines);

            internal static CreateProgramPipelines glCreateProgramPipelines;

            internal delegate void CreateQueries(OpenGL.QueryTarget target, Int32 n, UInt32[] ids);

            internal static CreateQueries glCreateQueries;

            internal delegate void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers);

            internal static CreateRenderbuffers glCreateRenderbuffers;

            internal delegate void CreateSamplers(Int32 n, UInt32[] samplers);

            internal static CreateSamplers glCreateSamplers;

            internal delegate UInt32 CreateShader(OpenGL.ShaderType shaderType);

            internal static CreateShader glCreateShader;

            internal delegate UInt32 CreateShaderProgramv(OpenGL.ShaderType type, Int32 count, String strings);

            internal static CreateShaderProgramv glCreateShaderProgramv;

            internal delegate void CreateTextures(OpenGL.TextureTarget target, Int32 n, UInt32[] textures);

            internal static CreateTextures glCreateTextures;

            internal delegate void CreateTransformFeedbacks(Int32 n, UInt32[] ids);

            internal static CreateTransformFeedbacks glCreateTransformFeedbacks;

            internal delegate void CreateVertexArrays(Int32 n, UInt32[] arrays);

            internal static CreateVertexArrays glCreateVertexArrays;

            internal delegate void CullFace(OpenGL.CullFaceMode mode);

            internal static CullFace glCullFace;

            internal delegate void DeleteBuffers(Int32 n, UInt32[] buffers);

            internal static DeleteBuffers glDeleteBuffers;

            internal delegate void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);

            internal static DeleteFramebuffers glDeleteFramebuffers;

            internal delegate void DeleteProgram(UInt32 program);

            internal static DeleteProgram glDeleteProgram;

            internal delegate void DeleteProgramPipelines(Int32 n, UInt32[] pipelines);

            internal static DeleteProgramPipelines glDeleteProgramPipelines;

            internal delegate void DeleteQueries(Int32 n, UInt32[] ids);

            internal static DeleteQueries glDeleteQueries;

            internal delegate void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);

            internal static DeleteRenderbuffers glDeleteRenderbuffers;

            internal delegate void DeleteSamplers(Int32 n, UInt32[] samplers);

            internal static DeleteSamplers glDeleteSamplers;

            internal delegate void DeleteShader(UInt32 shader);

            internal static DeleteShader glDeleteShader;

            internal delegate void DeleteSync(IntPtr sync);

            internal static DeleteSync glDeleteSync;

            internal delegate void DeleteTextures(Int32 n, UInt32[] textures);

            internal static DeleteTextures glDeleteTextures;

            internal delegate void DeleteTransformFeedbacks(Int32 n, UInt32[] ids);

            internal static DeleteTransformFeedbacks glDeleteTransformFeedbacks;

            internal delegate void DeleteVertexArrays(Int32 n, UInt32[] arrays);

            internal static DeleteVertexArrays glDeleteVertexArrays;

            internal delegate void DepthFunc(OpenGL.DepthFunction func);

            internal static DepthFunc glDepthFunc;

            internal delegate void DepthMask(Boolean flag);

            internal static DepthMask glDepthMask;

            internal delegate void DepthRange(Double nearVal, Double farVal);

            internal static DepthRange glDepthRange;

            internal delegate void DepthRangef(Single nearVal, Single farVal);

            internal static DepthRangef glDepthRangef;

            internal delegate void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v);

            internal static DepthRangeArrayv glDepthRangeArrayv;

            internal delegate void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal);

            internal static DepthRangeIndexed glDepthRangeIndexed;

            internal delegate void DetachShader(UInt32 program, UInt32 shader);

            internal static DetachShader glDetachShader;

            internal delegate void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);

            internal static DispatchCompute glDispatchCompute;

            internal delegate void DispatchComputeIndirect(IntPtr indirect);

            internal static DispatchComputeIndirect glDispatchComputeIndirect;

            internal delegate void DrawArrays(OpenGL.BeginMode mode, Int32 first, Int32 count);

            internal static DrawArrays glDrawArrays;

            internal delegate void DrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect);

            internal static DrawArraysIndirect glDrawArraysIndirect;

            internal delegate void DrawArraysInstanced(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);

            internal static DrawArraysInstanced glDrawArraysInstanced;

            internal delegate void DrawArraysInstancedBaseInstance(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance);

            internal static DrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance;

            internal delegate void DrawBuffer(OpenGL.DrawBufferMode buf);

            internal static DrawBuffer glDrawBuffer;

            internal delegate void NamedFramebufferDrawBuffer(UInt32 framebuffer, OpenGL.DrawBufferMode buf);

            internal static NamedFramebufferDrawBuffer glNamedFramebufferDrawBuffer;

            internal delegate void DrawBuffers(Int32 n, OpenGL.DrawBuffersEnum[] bufs);

            internal static DrawBuffers glDrawBuffers;

            internal delegate void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, OpenGL.DrawBufferMode[] bufs);

            internal static NamedFramebufferDrawBuffers glNamedFramebufferDrawBuffers;

            internal delegate void DrawElements(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);

            internal static DrawElements glDrawElements;

            internal delegate void DrawElementsBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);

            internal static DrawElementsBaseVertex glDrawElementsBaseVertex;

            internal delegate void DrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect);

            internal static DrawElementsIndirect glDrawElementsIndirect;

            internal delegate void DrawElementsInstanced(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);

            internal static DrawElementsInstanced glDrawElementsInstanced;

            internal delegate void DrawElementsInstancedBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance);

            internal static DrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance;

            internal delegate void DrawElementsInstancedBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);

            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;

            internal delegate void DrawElementsInstancedBaseVertexBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance);

            internal static DrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance;

            internal delegate void DrawRangeElements(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);

            internal static DrawRangeElements glDrawRangeElements;

            internal delegate void DrawRangeElementsBaseVertex(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);

            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;

            internal delegate void DrawTransformFeedback(OpenGL.NvTransformFeedback2 mode, UInt32 id);

            internal static DrawTransformFeedback glDrawTransformFeedback;

            internal delegate void DrawTransformFeedbackInstanced(OpenGL.BeginMode mode, UInt32 id, Int32 primcount);

            internal static DrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced;

            internal delegate void DrawTransformFeedbackStream(OpenGL.NvTransformFeedback2 mode, UInt32 id, UInt32 stream);

            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;

            internal delegate void DrawTransformFeedbackStreamInstanced(OpenGL.BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount);

            internal static DrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced;

            internal delegate void Enable(OpenGL.EnableCap cap);

            internal static Enable glEnable;

            internal delegate void Disable(OpenGL.EnableCap cap);

            internal static Disable glDisable;

            internal delegate void Enablei(OpenGL.EnableCap cap, UInt32 index);

            internal static Enablei glEnablei;

            internal delegate void Disablei(OpenGL.EnableCap cap, UInt32 index);

            internal static Disablei glDisablei;

            internal delegate void EnableVertexAttribArray(UInt32 index);

            internal static EnableVertexAttribArray glEnableVertexAttribArray;

            internal delegate void DisableVertexAttribArray(UInt32 index);

            internal static DisableVertexAttribArray glDisableVertexAttribArray;

            internal delegate void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

            internal static EnableVertexArrayAttrib glEnableVertexArrayAttrib;

            internal delegate void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

            internal static DisableVertexArrayAttrib glDisableVertexArrayAttrib;

            internal delegate IntPtr FenceSync(OpenGL.ArbSync condition, UInt32 flags);

            internal static FenceSync glFenceSync;

            internal delegate void Finish();

            internal static Finish glFinish;

            internal delegate void Flush();

            internal static Flush glFlush;

            internal delegate void FlushMappedBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length);

            internal static FlushMappedBufferRange glFlushMappedBufferRange;

            internal delegate void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length);

            internal static FlushMappedNamedBufferRange glFlushMappedNamedBufferRange;

            internal delegate void FramebufferParameteri(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, Int32 param);

            internal static FramebufferParameteri glFramebufferParameteri;

            internal delegate void NamedFramebufferParameteri(UInt32 framebuffer, OpenGL.FramebufferPName pname, Int32 param);

            internal static NamedFramebufferParameteri glNamedFramebufferParameteri;

            internal delegate void FramebufferRenderbuffer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;

            internal delegate void NamedFramebufferRenderbuffer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

            internal static NamedFramebufferRenderbuffer glNamedFramebufferRenderbuffer;

            internal delegate void FramebufferTexture(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);

            internal static FramebufferTexture glFramebufferTexture;

            internal delegate void FramebufferTexture1D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);

            internal static FramebufferTexture1D glFramebufferTexture1D;

            internal delegate void FramebufferTexture2D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);

            internal static FramebufferTexture2D glFramebufferTexture2D;

            internal delegate void FramebufferTexture3D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer);

            internal static FramebufferTexture3D glFramebufferTexture3D;

            internal delegate void NamedFramebufferTexture(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);

            internal static NamedFramebufferTexture glNamedFramebufferTexture;

            internal delegate void FramebufferTextureLayer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);

            internal static FramebufferTextureLayer glFramebufferTextureLayer;

            internal delegate void NamedFramebufferTextureLayer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);

            internal static NamedFramebufferTextureLayer glNamedFramebufferTextureLayer;

            internal delegate void FrontFace(OpenGL.FrontFaceDirection mode);

            internal static FrontFace glFrontFace;

            internal delegate void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);

            internal static GenBuffers glGenBuffers;

            internal delegate void GenerateMipmap(OpenGL.GenerateMipmapTarget target);

            internal static GenerateMipmap glGenerateMipmap;

            internal delegate void GenerateTextureMipmap(UInt32 texture);

            internal static GenerateTextureMipmap glGenerateTextureMipmap;

            internal delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] ids);

            internal static GenFramebuffers glGenFramebuffers;

            internal delegate void GenProgramPipelines(Int32 n, [OutAttribute] UInt32[] pipelines);

            internal static GenProgramPipelines glGenProgramPipelines;

            internal delegate void GenQueries(Int32 n, [OutAttribute] UInt32[] ids);

            internal static GenQueries glGenQueries;

            internal delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);

            internal static GenRenderbuffers glGenRenderbuffers;

            internal delegate void GenSamplers(Int32 n, [OutAttribute] UInt32[] samplers);

            internal static GenSamplers glGenSamplers;

            internal delegate void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);

            internal static GenTextures glGenTextures;

            internal delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32[] ids);

            internal static GenTransformFeedbacks glGenTransformFeedbacks;

            internal delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays);

            internal static GenVertexArrays glGenVertexArrays;

            internal delegate void GetBooleanv(OpenGL.GetPName pname, [OutAttribute] Boolean[] data);

            internal static GetBooleanv glGetBooleanv;

            internal delegate void GetDoublev(OpenGL.GetPName pname, [OutAttribute] Double[] data);

            internal static GetDoublev glGetDoublev;

            internal delegate void GetFloatv(OpenGL.GetPName pname, [OutAttribute] Single[] data);

            internal static GetFloatv glGetFloatv;

            internal delegate void GetIntegerv(OpenGL.GetPName pname, [OutAttribute] Int32[] data);

            internal static GetIntegerv glGetIntegerv;

            internal delegate void GetInteger64v(OpenGL.ArbSync pname, [OutAttribute] Int64[] data);

            internal static GetInteger64v glGetInteger64v;

            internal delegate void GetBooleani_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Boolean[] data);

            internal static GetBooleani_v glGetBooleani_v;

            internal delegate void GetIntegeri_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int32[] data);

            internal static GetIntegeri_v glGetIntegeri_v;

            internal delegate void GetFloati_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Single[] data);

            internal static GetFloati_v glGetFloati_v;

            internal delegate void GetDoublei_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Double[] data);

            internal static GetDoublei_v glGetDoublei_v;

            internal delegate void GetInteger64i_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int64[] data);

            internal static GetInteger64i_v glGetInteger64i_v;

            internal delegate void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenGL.AtomicCounterParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv;

            internal delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);

            internal static GetActiveAttrib glGetActiveAttrib;

            internal delegate void GetActiveSubroutineName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            internal static GetActiveSubroutineName glGetActiveSubroutineName;

            internal delegate void GetActiveSubroutineUniformiv(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, OpenGL.SubroutineParameterName pname, [OutAttribute] Int32[] values);

            internal static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;

            internal delegate void GetActiveSubroutineUniformName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            internal static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;

            internal delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveUniformType[] type, [OutAttribute] System.Text.StringBuilder name);

            internal static GetActiveUniform glGetActiveUniform;

            internal delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenGL.ActiveUniformBlockParameter pname, [OutAttribute] Int32[] @params);

            internal static GetActiveUniformBlockiv glGetActiveUniformBlockiv;

            internal delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformBlockName);

            internal static GetActiveUniformBlockName glGetActiveUniformBlockName;

            internal delegate void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformName);

            internal static GetActiveUniformName glGetActiveUniformName;

            internal delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, [OutAttribute] UInt32[] uniformIndices, OpenGL.ActiveUniformType pname, [OutAttribute] Int32[] @params);

            internal static GetActiveUniformsiv glGetActiveUniformsiv;

            internal delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32[] count, [OutAttribute] UInt32[] shaders);

            internal static GetAttachedShaders glGetAttachedShaders;

            internal delegate Int32 GetAttribLocation(UInt32 program, String name);

            internal static GetAttribLocation glGetAttribLocation;

            internal delegate void GetBufferParameteriv(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int32[] data);

            internal static GetBufferParameteriv glGetBufferParameteriv;

            internal delegate void GetBufferParameteri64v(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int64[] data);

            internal static GetBufferParameteri64v glGetBufferParameteri64v;

            internal delegate void GetNamedBufferParameteriv(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetNamedBufferParameteriv glGetNamedBufferParameteriv;

            internal delegate void GetNamedBufferParameteri64v(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int64[] @params);

            internal static GetNamedBufferParameteri64v glGetNamedBufferParameteri64v;

            internal delegate void GetBufferPointerv(OpenGL.BufferTarget target, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);

            internal static GetBufferPointerv glGetBufferPointerv;

            internal delegate void GetNamedBufferPointerv(UInt32 buffer, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);

            internal static GetNamedBufferPointerv glGetNamedBufferPointerv;

            internal delegate void GetBufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);

            internal static GetBufferSubData glGetBufferSubData;

            internal delegate void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, [OutAttribute] IntPtr data);

            internal static GetNamedBufferSubData glGetNamedBufferSubData;

            internal delegate void GetCompressedTexImage(OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr pixels);

            internal static GetCompressedTexImage glGetCompressedTexImage;

            internal delegate void GetnCompressedTexImage(OpenGL.TextureTarget target, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetnCompressedTexImage glGetnCompressedTexImage;

            internal delegate void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetCompressedTextureImage glGetCompressedTextureImage;

            internal delegate void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetCompressedTextureSubImage glGetCompressedTextureSubImage;

            internal delegate OpenGL.ErrorCode GetError();

            internal static GetError glGetError;

            internal delegate Int32 GetFragDataIndex(UInt32 program, String name);

            internal static GetFragDataIndex glGetFragDataIndex;

            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);

            internal static GetFragDataLocation glGetFragDataLocation;

            internal delegate void GetFramebufferAttachmentParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;

            internal delegate void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetNamedFramebufferAttachmentParameteriv glGetNamedFramebufferAttachmentParameteriv;

            internal delegate void GetFramebufferParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] @params);

            internal static GetFramebufferParameteriv glGetFramebufferParameteriv;

            internal delegate void GetNamedFramebufferParameteriv(UInt32 framebuffer, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] param);

            internal static GetNamedFramebufferParameteriv glGetNamedFramebufferParameteriv;

            internal delegate OpenGL.GraphicResetStatus GetGraphicsResetStatus();

            internal static GetGraphicsResetStatus glGetGraphicsResetStatus;

            internal delegate void GetInternalformativ(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int32[] @params);

            internal static GetInternalformativ glGetInternalformativ;

            internal delegate void GetInternalformati64v(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int64[] @params);

            internal static GetInternalformati64v glGetInternalformati64v;

            internal delegate void GetMultisamplefv(OpenGL.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single[] val);

            internal static GetMultisamplefv glGetMultisamplefv;

            internal delegate void GetObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);

            internal static GetObjectLabel glGetObjectLabel;

            internal delegate void GetObjectPtrLabel([OutAttribute] IntPtr ptr, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);

            internal static GetObjectPtrLabel glGetObjectPtrLabel;

            internal delegate void GetPointerv(OpenGL.GetPointerParameter pname, [OutAttribute] IntPtr @params);

            internal static GetPointerv glGetPointerv;

            internal delegate void GetProgramiv(UInt32 program, OpenGL.ProgramParameter pname, [OutAttribute] Int32[] @params);

            internal static GetProgramiv glGetProgramiv;

            internal delegate void GetProgramBinary(UInt32 program, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] binaryFormat, [OutAttribute] IntPtr binary);

            internal static GetProgramBinary glGetProgramBinary;

            internal delegate void GetProgramInfoLog(UInt32 program, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            internal static GetProgramInfoLog glGetProgramInfoLog;

            internal delegate void GetProgramInterfaceiv(UInt32 program, OpenGL.ProgramInterface programInterface, OpenGL.ProgramInterfaceParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetProgramInterfaceiv glGetProgramInterfaceiv;

            internal delegate void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, [OutAttribute] Int32[] @params);

            internal static GetProgramPipelineiv glGetProgramPipelineiv;

            internal delegate void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            internal static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;

            internal delegate void GetProgramResourceiv(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 propCount, [OutAttribute] OpenGL.ProgramResourceParameterName[] props, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] @params);

            internal static GetProgramResourceiv glGetProgramResourceiv;

            internal delegate UInt32 GetProgramResourceIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            internal static GetProgramResourceIndex glGetProgramResourceIndex;

            internal delegate Int32 GetProgramResourceLocation(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            internal static GetProgramResourceLocation glGetProgramResourceLocation;

            internal delegate Int32 GetProgramResourceLocationIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);

            internal static GetProgramResourceLocationIndex glGetProgramResourceLocationIndex;

            internal delegate void GetProgramResourceName(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);

            internal static GetProgramResourceName glGetProgramResourceName;

            internal delegate void GetProgramStageiv(UInt32 program, OpenGL.ShaderType shadertype, OpenGL.ProgramStageParameterName pname, [OutAttribute] Int32[] values);

            internal static GetProgramStageiv glGetProgramStageiv;

            internal delegate void GetQueryIndexediv(OpenGL.QueryTarget target, UInt32 index, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);

            internal static GetQueryIndexediv glGetQueryIndexediv;

            internal delegate void GetQueryiv(OpenGL.QueryTarget target, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);

            internal static GetQueryiv glGetQueryiv;

            internal delegate void GetQueryObjectiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int32[] @params);

            internal static GetQueryObjectiv glGetQueryObjectiv;

            internal delegate void GetQueryObjectuiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt32[] @params);

            internal static GetQueryObjectuiv glGetQueryObjectuiv;

            internal delegate void GetQueryObjecti64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int64[] @params);

            internal static GetQueryObjecti64v glGetQueryObjecti64v;

            internal delegate void GetQueryObjectui64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt64[] @params);

            internal static GetQueryObjectui64v glGetQueryObjectui64v;

            internal delegate void GetRenderbufferParameteriv(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetRenderbufferParameteriv glGetRenderbufferParameteriv;

            internal delegate void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetNamedRenderbufferParameteriv glGetNamedRenderbufferParameteriv;

            internal delegate void GetSamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Single[] @params);

            internal static GetSamplerParameterfv glGetSamplerParameterfv;

            internal delegate void GetSamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetSamplerParameteriv glGetSamplerParameteriv;

            internal delegate void GetSamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);

            internal static GetSamplerParameterIiv glGetSamplerParameterIiv;

            internal delegate void GetSamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] UInt32[] @params);

            internal static GetSamplerParameterIuiv glGetSamplerParameterIuiv;

            internal delegate void GetShaderiv(UInt32 shader, OpenGL.ShaderParameter pname, [OutAttribute] Int32[] @params);

            internal static GetShaderiv glGetShaderiv;

            internal delegate void GetShaderInfoLog(UInt32 shader, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);

            internal static GetShaderInfoLog glGetShaderInfoLog;

            internal delegate void GetShaderPrecisionFormat(OpenGL.ShaderType shaderType, Int32 precisionType, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);

            internal static GetShaderPrecisionFormat glGetShaderPrecisionFormat;

            internal delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder source);

            internal static GetShaderSource glGetShaderSource;

            internal delegate IntPtr GetString(OpenGL.StringName name);

            internal static GetString glGetString;

            internal delegate IntPtr GetStringi(OpenGL.StringName name, UInt32 index);

            internal static GetStringi glGetStringi;

            internal delegate UInt32 GetSubroutineIndex(UInt32 program, OpenGL.ShaderType shadertype, String name);

            internal static GetSubroutineIndex glGetSubroutineIndex;

            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program, OpenGL.ShaderType shadertype, String name);

            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;

            internal delegate void GetSynciv(IntPtr sync, OpenGL.ArbSync pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values);

            internal static GetSynciv glGetSynciv;

            internal delegate void GetTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, [OutAttribute] IntPtr pixels);

            internal static GetTexImage glGetTexImage;

            internal delegate void GetnTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetnTexImage glGetnTexImage;

            internal delegate void GetTextureImage(UInt32 texture, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetTextureImage glGetTextureImage;

            internal delegate void GetTexLevelParameterfv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);

            internal static GetTexLevelParameterfv glGetTexLevelParameterfv;

            internal delegate void GetTexLevelParameteriv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTexLevelParameteriv glGetTexLevelParameteriv;

            internal delegate void GetTextureLevelParameterfv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);

            internal static GetTextureLevelParameterfv glGetTextureLevelParameterfv;

            internal delegate void GetTextureLevelParameteriv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTextureLevelParameteriv glGetTextureLevelParameteriv;

            internal delegate void GetTexParameterfv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);

            internal static GetTexParameterfv glGetTexParameterfv;

            internal delegate void GetTexParameteriv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTexParameteriv glGetTexParameteriv;

            internal delegate void GetTexParameterIiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTexParameterIiv glGetTexParameterIiv;

            internal delegate void GetTexParameterIuiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);

            internal static GetTexParameterIuiv glGetTexParameterIuiv;

            internal delegate void GetTextureParameterfv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);

            internal static GetTextureParameterfv glGetTextureParameterfv;

            internal delegate void GetTextureParameteriv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTextureParameteriv glGetTextureParameteriv;

            internal delegate void GetTextureParameterIiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);

            internal static GetTextureParameterIiv glGetTextureParameterIiv;

            internal delegate void GetTextureParameterIuiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);

            internal static GetTextureParameterIuiv glGetTextureParameterIuiv;

            internal delegate void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);

            internal static GetTextureSubImage glGetTextureSubImage;

            internal delegate void GetTransformFeedbackiv(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, [OutAttribute] Int32[] param);

            internal static GetTransformFeedbackiv glGetTransformFeedbackiv;

            internal delegate void GetTransformFeedbacki_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int32[] param);

            internal static GetTransformFeedbacki_v glGetTransformFeedbacki_v;

            internal delegate void GetTransformFeedbacki64_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int64[] param);

            internal static GetTransformFeedbacki64_v glGetTransformFeedbacki64_v;

            internal delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);

            internal static GetTransformFeedbackVarying glGetTransformFeedbackVarying;

            internal delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single[] @params);

            internal static GetUniformfv glGetUniformfv;

            internal delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32[] @params);

            internal static GetUniformiv glGetUniformiv;

            internal delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32[] @params);

            internal static GetUniformuiv glGetUniformuiv;

            internal delegate void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double[] @params);

            internal static GetUniformdv glGetUniformdv;

            internal delegate void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);

            internal static GetnUniformfv glGetnUniformfv;

            internal delegate void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);

            internal static GetnUniformiv glGetnUniformiv;

            internal delegate void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32[] @params);

            internal static GetnUniformuiv glGetnUniformuiv;

            internal delegate void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double[] @params);

            internal static GetnUniformdv glGetnUniformdv;

            internal delegate UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);

            internal static GetUniformBlockIndex glGetUniformBlockIndex;

            internal delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String uniformNames, [OutAttribute] UInt32[] uniformIndices);

            internal static GetUniformIndices glGetUniformIndices;

            internal delegate Int32 GetUniformLocation(UInt32 program, String name);

            internal static GetUniformLocation glGetUniformLocation;

            internal delegate void GetUniformSubroutineuiv(OpenGL.ShaderType shadertype, Int32 location, [OutAttribute] UInt32[] values);

            internal static GetUniformSubroutineuiv glGetUniformSubroutineuiv;

            internal delegate void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int64[] param);

            internal static GetVertexArrayIndexed64iv glGetVertexArrayIndexed64iv;

            internal delegate void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);

            internal static GetVertexArrayIndexediv glGetVertexArrayIndexediv;

            internal delegate void GetVertexArrayiv(UInt32 vaobj, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);

            internal static GetVertexArrayiv glGetVertexArrayiv;

            internal delegate void GetVertexAttribdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);

            internal static GetVertexAttribdv glGetVertexAttribdv;

            internal delegate void GetVertexAttribfv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Single[] @params);

            internal static GetVertexAttribfv glGetVertexAttribfv;

            internal delegate void GetVertexAttribiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);

            internal static GetVertexAttribiv glGetVertexAttribiv;

            internal delegate void GetVertexAttribIiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);

            internal static GetVertexAttribIiv glGetVertexAttribIiv;

            internal delegate void GetVertexAttribIuiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] UInt32[] @params);

            internal static GetVertexAttribIuiv glGetVertexAttribIuiv;

            internal delegate void GetVertexAttribLdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);

            internal static GetVertexAttribLdv glGetVertexAttribLdv;

            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenGL.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);

            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;

            internal delegate void Hint(OpenGL.HintTarget target, OpenGL.HintMode mode);

            internal static Hint glHint;

            internal delegate void InvalidateBufferData(UInt32 buffer);

            internal static InvalidateBufferData glInvalidateBufferData;

            internal delegate void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);

            internal static InvalidateBufferSubData glInvalidateBufferSubData;

            internal delegate void InvalidateFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);

            internal static InvalidateFramebuffer glInvalidateFramebuffer;

            internal delegate void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);

            internal static InvalidateNamedFramebufferData glInvalidateNamedFramebufferData;

            internal delegate void InvalidateSubFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static InvalidateSubFramebuffer glInvalidateSubFramebuffer;

            internal delegate void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);

            internal static InvalidateNamedFramebufferSubData glInvalidateNamedFramebufferSubData;

            internal delegate void InvalidateTexImage(UInt32 texture, Int32 level);

            internal static InvalidateTexImage glInvalidateTexImage;

            internal delegate void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);

            internal static InvalidateTexSubImage glInvalidateTexSubImage;

            internal delegate Boolean IsBuffer(UInt32 buffer);

            internal static IsBuffer glIsBuffer;

            internal delegate Boolean IsEnabled(OpenGL.EnableCap cap);

            internal static IsEnabled glIsEnabled;

            internal delegate Boolean IsEnabledi(OpenGL.EnableCap cap, UInt32 index);

            internal static IsEnabledi glIsEnabledi;

            internal delegate Boolean IsFramebuffer(UInt32 framebuffer);

            internal static IsFramebuffer glIsFramebuffer;

            internal delegate Boolean IsProgram(UInt32 program);

            internal static IsProgram glIsProgram;

            internal delegate Boolean IsProgramPipeline(UInt32 pipeline);

            internal static IsProgramPipeline glIsProgramPipeline;

            internal delegate Boolean IsQuery(UInt32 id);

            internal static IsQuery glIsQuery;

            internal delegate Boolean IsRenderbuffer(UInt32 renderbuffer);

            internal static IsRenderbuffer glIsRenderbuffer;

            internal delegate Boolean IsSampler(UInt32 id);

            internal static IsSampler glIsSampler;

            internal delegate Boolean IsShader(UInt32 shader);

            internal static IsShader glIsShader;

            internal delegate Boolean IsSync(IntPtr sync);

            internal static IsSync glIsSync;

            internal delegate Boolean IsTexture(UInt32 texture);

            internal static IsTexture glIsTexture;

            internal delegate Boolean IsTransformFeedback(UInt32 id);

            internal static IsTransformFeedback glIsTransformFeedback;

            internal delegate Boolean IsVertexArray(UInt32 array);

            internal static IsVertexArray glIsVertexArray;

            internal delegate void LineWidth(Single width);

            internal static LineWidth glLineWidth;

            internal delegate void LinkProgram(UInt32 program);

            internal static LinkProgram glLinkProgram;

            internal delegate void LogicOp(OpenGL.LogicOp opcode);

            internal static LogicOp glLogicOp;

            internal delegate IntPtr MapBuffer(OpenGL.BufferTarget target, OpenGL.BufferAccess access);

            internal static MapBuffer glMapBuffer;

            internal delegate IntPtr MapNamedBuffer(UInt32 buffer, OpenGL.BufferAccess access);

            internal static MapNamedBuffer glMapNamedBuffer;

            internal delegate IntPtr MapBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length, OpenGL.BufferAccessMask access);

            internal static MapBufferRange glMapBufferRange;

            internal delegate IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access);

            internal static MapNamedBufferRange glMapNamedBufferRange;

            internal delegate void MemoryBarrier(UInt32 barriers);

            internal static MemoryBarrier glMemoryBarrier;

            internal delegate void MemoryBarrierByRegion(UInt32 barriers);

            internal static MemoryBarrierByRegion glMemoryBarrierByRegion;

            internal delegate void MinSampleShading(Single value);

            internal static MinSampleShading glMinSampleShading;

            internal delegate void MultiDrawArrays(OpenGL.BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount);

            internal static MultiDrawArrays glMultiDrawArrays;

            internal delegate void MultiDrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride);

            internal static MultiDrawArraysIndirect glMultiDrawArraysIndirect;

            internal delegate void MultiDrawElements(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount);

            internal static MultiDrawElements glMultiDrawElements;

            internal delegate void MultiDrawElementsBaseVertex(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex);

            internal static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;

            internal delegate void MultiDrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);

            internal static MultiDrawElementsIndirect glMultiDrawElementsIndirect;

            internal delegate void ObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 length, String label);

            internal static ObjectLabel glObjectLabel;

            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);

            internal static ObjectPtrLabel glObjectPtrLabel;

            internal delegate void PatchParameteri(Int32 pname, Int32 value);

            internal static PatchParameteri glPatchParameteri;

            internal delegate void PatchParameterfv(Int32 pname, Single[] values);

            internal static PatchParameterfv glPatchParameterfv;

            internal delegate void PixelStoref(OpenGL.PixelStoreParameter pname, Single param);

            internal static PixelStoref glPixelStoref;

            internal delegate void PixelStorei(OpenGL.PixelStoreParameter pname, Int32 param);

            internal static PixelStorei glPixelStorei;

            internal delegate void PointParameterf(OpenGL.PointParameterName pname, Single param);

            internal static PointParameterf glPointParameterf;

            internal delegate void PointParameteri(OpenGL.PointParameterName pname, Int32 param);

            internal static PointParameteri glPointParameteri;

            internal delegate void PointParameterfv(OpenGL.PointParameterName pname, Single[] @params);

            internal static PointParameterfv glPointParameterfv;

            internal delegate void PointParameteriv(OpenGL.PointParameterName pname, Int32[] @params);

            internal static PointParameteriv glPointParameteriv;

            internal delegate void PointSize(Single size);

            internal static PointSize glPointSize;

            internal delegate void PolygonMode(OpenGL.MaterialFace face, OpenGL.PolygonMode mode);

            internal static PolygonMode glPolygonMode;

            internal delegate void PolygonOffset(Single factor, Single units);

            internal static PolygonOffset glPolygonOffset;

            internal delegate void PrimitiveRestartIndex(UInt32 index);

            internal static PrimitiveRestartIndex glPrimitiveRestartIndex;

            internal delegate void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);

            internal static ProgramBinary glProgramBinary;

            internal delegate void ProgramParameteri(UInt32 program, OpenGL.Version32 pname, Int32 value);

            internal static ProgramParameteri glProgramParameteri;

            internal delegate void ProgramUniform1f(UInt32 program, Int32 location, Single v0);

            internal static ProgramUniform1f glProgramUniform1f;

            internal delegate void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);

            internal static ProgramUniform2f glProgramUniform2f;

            internal delegate void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);

            internal static ProgramUniform3f glProgramUniform3f;

            internal delegate void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);

            internal static ProgramUniform4f glProgramUniform4f;

            internal delegate void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

            internal static ProgramUniform1i glProgramUniform1i;

            internal delegate void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

            internal static ProgramUniform2i glProgramUniform2i;

            internal delegate void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

            internal static ProgramUniform3i glProgramUniform3i;

            internal delegate void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            internal static ProgramUniform4i glProgramUniform4i;

            internal delegate void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

            internal static ProgramUniform1ui glProgramUniform1ui;

            internal delegate void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1);

            internal static ProgramUniform2ui glProgramUniform2ui;

            internal delegate void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2);

            internal static ProgramUniform3ui glProgramUniform3ui;

            internal delegate void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3);

            internal static ProgramUniform4ui glProgramUniform4ui;

            internal delegate void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            internal static ProgramUniform1fv glProgramUniform1fv;

            internal delegate void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            internal static ProgramUniform2fv glProgramUniform2fv;

            internal delegate void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            internal static ProgramUniform3fv glProgramUniform3fv;

            internal delegate void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value);

            internal static ProgramUniform4fv glProgramUniform4fv;

            internal delegate void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            internal static ProgramUniform1iv glProgramUniform1iv;

            internal delegate void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            internal static ProgramUniform2iv glProgramUniform2iv;

            internal delegate void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            internal static ProgramUniform3iv glProgramUniform3iv;

            internal delegate void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value);

            internal static ProgramUniform4iv glProgramUniform4iv;

            internal delegate void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            internal static ProgramUniform1uiv glProgramUniform1uiv;

            internal delegate void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            internal static ProgramUniform2uiv glProgramUniform2uiv;

            internal delegate void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            internal static ProgramUniform3uiv glProgramUniform3uiv;

            internal delegate void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);

            internal static ProgramUniform4uiv glProgramUniform4uiv;

            internal delegate void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;

            internal delegate void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;

            internal delegate void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;

            internal delegate void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;

            internal delegate void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;

            internal delegate void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;

            internal delegate void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;

            internal delegate void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;

            internal delegate void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;

            internal delegate void ProvokingVertex(OpenGL.ProvokingVertexMode provokeMode);

            internal static ProvokingVertex glProvokingVertex;

            internal delegate void QueryCounter(UInt32 id, OpenGL.QueryTarget target);

            internal static QueryCounter glQueryCounter;

            internal delegate void ReadBuffer(OpenGL.ReadBufferMode mode);

            internal static ReadBuffer glReadBuffer;

            internal delegate void NamedFramebufferReadBuffer(OpenGL.ReadBufferMode framebuffer, OpenGL.BeginMode mode);

            internal static NamedFramebufferReadBuffer glNamedFramebufferReadBuffer;

            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32[] data);

            internal static ReadPixels glReadPixels;

            internal delegate void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, Int32[] data);

            internal static ReadnPixels glReadnPixels;

            internal delegate void RenderbufferStorage(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            internal static RenderbufferStorage glRenderbufferStorage;

            internal delegate void NamedRenderbufferStorage(UInt32 renderbuffer, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            internal static NamedRenderbufferStorage glNamedRenderbufferStorage;

            internal delegate void RenderbufferStorageMultisample(OpenGL.RenderbufferTarget target, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;

            internal delegate void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);

            internal static NamedRenderbufferStorageMultisample glNamedRenderbufferStorageMultisample;

            internal delegate void SampleCoverage(Single value, Boolean invert);

            internal static SampleCoverage glSampleCoverage;

            internal delegate void SampleMaski(UInt32 maskNumber, UInt32 mask);

            internal static SampleMaski glSampleMaski;

            internal delegate void SamplerParameterf(UInt32 sampler, OpenGL.TextureParameterName pname, Single param);

            internal static SamplerParameterf glSamplerParameterf;

            internal delegate void SamplerParameteri(UInt32 sampler, OpenGL.TextureParameterName pname, Int32 param);

            internal static SamplerParameteri glSamplerParameteri;

            internal delegate void SamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, Single[] @params);

            internal static SamplerParameterfv glSamplerParameterfv;

            internal delegate void SamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);

            internal static SamplerParameteriv glSamplerParameteriv;

            internal delegate void SamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);

            internal static SamplerParameterIiv glSamplerParameterIiv;

            internal delegate void SamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, UInt32[] @params);

            internal static SamplerParameterIuiv glSamplerParameterIuiv;

            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);

            internal static Scissor glScissor;

            internal delegate void ScissorArrayv(UInt32 first, Int32 count, Int32[] v);

            internal static ScissorArrayv glScissorArrayv;

            internal delegate void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

            internal static ScissorIndexed glScissorIndexed;

            internal delegate void ScissorIndexedv(UInt32 index, Int32[] v);

            internal static ScissorIndexedv glScissorIndexedv;

            internal delegate void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length);

            internal static ShaderBinary glShaderBinary;

            internal delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);

            internal static ShaderSource glShaderSource;

            internal delegate void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);

            internal static ShaderStorageBlockBinding glShaderStorageBlockBinding;

            internal delegate void StencilFunc(OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);

            internal static StencilFunc glStencilFunc;

            internal delegate void StencilFuncSeparate(OpenGL.StencilFace face, OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);

            internal static StencilFuncSeparate glStencilFuncSeparate;

            internal delegate void StencilMask(UInt32 mask);

            internal static StencilMask glStencilMask;

            internal delegate void StencilMaskSeparate(OpenGL.StencilFace face, UInt32 mask);

            internal static StencilMaskSeparate glStencilMaskSeparate;

            internal delegate void StencilOp(OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);

            internal static StencilOp glStencilOp;

            internal delegate void StencilOpSeparate(OpenGL.StencilFace face, OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);

            internal static StencilOpSeparate glStencilOpSeparate;

            internal delegate void TexBuffer(OpenGL.TextureBufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);

            internal static TexBuffer glTexBuffer;

            internal delegate void TextureBuffer(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);

            internal static TextureBuffer glTextureBuffer;

            internal delegate void TexBufferRange(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size);

            internal static TexBufferRange glTexBufferRange;

            internal delegate void TextureBufferRange(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size);

            internal static TextureBufferRange glTextureBufferRange;

            internal delegate void TexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            internal static TexImage1D glTexImage1D;

            internal delegate void TexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            internal static TexImage2D glTexImage2D;

            internal delegate void TexImage2DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            internal static TexImage2DMultisample glTexImage2DMultisample;

            internal delegate void TexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);

            internal static TexImage3D glTexImage3D;

            internal delegate void TexImage3DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            internal static TexImage3DMultisample glTexImage3DMultisample;

            internal delegate void TexParameterf(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single param);

            internal static TexParameterf glTexParameterf;

            internal delegate void TexParameteri(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32 param);

            internal static TexParameteri glTexParameteri;

            internal delegate void TextureParameterf(UInt32 texture, OpenGL.TextureParameter pname, Single param);

            internal static TextureParameterf glTextureParameterf;

            internal delegate void TextureParameteri(UInt32 texture, OpenGL.TextureParameter pname, Int32 param);

            internal static TextureParameteri glTextureParameteri;

            internal delegate void TexParameterfv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single[] @params);

            internal static TexParameterfv glTexParameterfv;

            internal delegate void TexParameteriv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);

            internal static TexParameteriv glTexParameteriv;

            internal delegate void TexParameterIiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);

            internal static TexParameterIiv glTexParameterIiv;

            internal delegate void TexParameterIuiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, UInt32[] @params);

            internal static TexParameterIuiv glTexParameterIuiv;

            internal delegate void TextureParameterfv(UInt32 texture, OpenGL.TextureParameter pname, Single[] paramtexture);

            internal static TextureParameterfv glTextureParameterfv;

            internal delegate void TextureParameteriv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] param);

            internal static TextureParameteriv glTextureParameteriv;

            internal delegate void TextureParameterIiv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] @params);

            internal static TextureParameterIiv glTextureParameterIiv;

            internal delegate void TextureParameterIuiv(UInt32 texture, OpenGL.TextureParameter pname, UInt32[] @params);

            internal static TextureParameterIuiv glTextureParameterIuiv;

            internal delegate void TexStorage1D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);

            internal static TexStorage1D glTexStorage1D;

            internal delegate void TextureStorage1D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);

            internal static TextureStorage1D glTextureStorage1D;

            internal delegate void TexStorage2D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);

            internal static TexStorage2D glTexStorage2D;

            internal delegate void TextureStorage2D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);

            internal static TextureStorage2D glTextureStorage2D;

            internal delegate void TexStorage2DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            internal static TexStorage2DMultisample glTexStorage2DMultisample;

            internal delegate void TextureStorage2DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);

            internal static TextureStorage2DMultisample glTextureStorage2DMultisample;

            internal delegate void TexStorage3D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);

            internal static TexStorage3D glTexStorage3D;

            internal delegate void TextureStorage3D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);

            internal static TextureStorage3D glTextureStorage3D;

            internal delegate void TexStorage3DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            internal static TexStorage3DMultisample glTexStorage3DMultisample;

            internal delegate void TextureStorage3DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

            internal static TextureStorage3DMultisample glTextureStorage3DMultisample;

            internal delegate void TexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TexSubImage1D glTexSubImage1D;

            internal delegate void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TextureSubImage1D glTextureSubImage1D;

            internal delegate void TexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TexSubImage2D glTexSubImage2D;

            internal delegate void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TextureSubImage2D glTextureSubImage2D;

            internal delegate void TexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TexSubImage3D glTexSubImage3D;

            internal delegate void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);

            internal static TextureSubImage3D glTextureSubImage3D;

            internal delegate void TextureBarrier();

            internal static TextureBarrier glTextureBarrier;

            internal delegate void TextureView(UInt32 texture, OpenGL.TextureTarget target, UInt32 origtexture, OpenGL.PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

            internal static TextureView glTextureView;

            internal delegate void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

            internal static TransformFeedbackBufferBase glTransformFeedbackBufferBase;

            internal delegate void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size);

            internal static TransformFeedbackBufferRange glTransformFeedbackBufferRange;

            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenGL.TransformFeedbackMode bufferMode);

            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;

            internal delegate void Uniform1f(Int32 location, Single v0);

            internal static Uniform1f glUniform1f;

            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);

            internal static Uniform2f glUniform2f;

            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);

            internal static Uniform3f glUniform3f;

            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);

            internal static Uniform4f glUniform4f;

            internal delegate void Uniform1i(Int32 location, Int32 v0);

            internal static Uniform1i glUniform1i;

            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);

            internal static Uniform2i glUniform2i;

            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

            internal static Uniform3i glUniform3i;

            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            internal static Uniform4i glUniform4i;

            internal delegate void Uniform1ui(Int32 location, UInt32 v0);

            internal static Uniform1ui glUniform1ui;

            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);

            internal static Uniform2ui glUniform2ui;

            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

            internal static Uniform3ui glUniform3ui;

            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

            internal static Uniform4ui glUniform4ui;

            internal delegate void Uniform1fv(Int32 location, Int32 count, Single[] value);

            internal static Uniform1fv glUniform1fv;

            internal delegate void Uniform2fv(Int32 location, Int32 count, Single[] value);

            internal static Uniform2fv glUniform2fv;

            internal delegate void Uniform3fv(Int32 location, Int32 count, Single[] value);

            internal static Uniform3fv glUniform3fv;

            internal delegate void Uniform4fv(Int32 location, Int32 count, Single[] value);

            internal static Uniform4fv glUniform4fv;

            internal delegate void Uniform1iv(Int32 location, Int32 count, Int32[] value);

            internal static Uniform1iv glUniform1iv;

            internal delegate void Uniform2iv(Int32 location, Int32 count, Int32[] value);

            internal static Uniform2iv glUniform2iv;

            internal delegate void Uniform3iv(Int32 location, Int32 count, Int32[] value);

            internal static Uniform3iv glUniform3iv;

            internal delegate void Uniform4iv(Int32 location, Int32 count, Int32[] value);

            internal static Uniform4iv glUniform4iv;

            internal delegate void Uniform1uiv(Int32 location, Int32 count, UInt32[] value);

            internal static Uniform1uiv glUniform1uiv;

            internal delegate void Uniform2uiv(Int32 location, Int32 count, UInt32[] value);

            internal static Uniform2uiv glUniform2uiv;

            internal delegate void Uniform3uiv(Int32 location, Int32 count, UInt32[] value);

            internal static Uniform3uiv glUniform3uiv;

            internal delegate void Uniform4uiv(Int32 location, Int32 count, UInt32[] value);

            internal static Uniform4uiv glUniform4uiv;

            internal delegate void UniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix2fv glUniformMatrix2fv;

            internal delegate void UniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix3fv glUniformMatrix3fv;

            internal delegate void UniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix4fv glUniformMatrix4fv;

            internal delegate void UniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix2x3fv glUniformMatrix2x3fv;

            internal delegate void UniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix3x2fv glUniformMatrix3x2fv;

            internal delegate void UniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix2x4fv glUniformMatrix2x4fv;

            internal delegate void UniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix4x2fv glUniformMatrix4x2fv;

            internal delegate void UniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix3x4fv glUniformMatrix3x4fv;

            internal delegate void UniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);

            internal static UniformMatrix4x3fv glUniformMatrix4x3fv;

            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);

            internal static UniformBlockBinding glUniformBlockBinding;

            internal delegate void UniformSubroutinesuiv(OpenGL.ShaderType shadertype, Int32 count, UInt32[] indices);

            internal static UniformSubroutinesuiv glUniformSubroutinesuiv;

            internal delegate Boolean UnmapBuffer(OpenGL.BufferTarget target);

            internal static UnmapBuffer glUnmapBuffer;

            internal delegate Boolean UnmapNamedBuffer(UInt32 buffer);

            internal static UnmapNamedBuffer glUnmapNamedBuffer;

            internal delegate void UseProgram(UInt32 program);

            internal static UseProgram glUseProgram;

            internal delegate void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

            internal static UseProgramStages glUseProgramStages;

            internal delegate void ValidateProgram(UInt32 program);

            internal static ValidateProgram glValidateProgram;

            internal delegate void ValidateProgramPipeline(UInt32 pipeline);

            internal static ValidateProgramPipeline glValidateProgramPipeline;

            internal delegate void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

            internal static VertexArrayElementBuffer glVertexArrayElementBuffer;

            internal delegate void VertexAttrib1f(UInt32 index, Single v0);

            internal static VertexAttrib1f glVertexAttrib1f;

            internal delegate void VertexAttrib1s(UInt32 index, Int16 v0);

            internal static VertexAttrib1s glVertexAttrib1s;

            internal delegate void VertexAttrib1d(UInt32 index, Double v0);

            internal static VertexAttrib1d glVertexAttrib1d;

            internal delegate void VertexAttribI1i(UInt32 index, Int32 v0);

            internal static VertexAttribI1i glVertexAttribI1i;

            internal delegate void VertexAttribI1ui(UInt32 index, UInt32 v0);

            internal static VertexAttribI1ui glVertexAttribI1ui;

            internal delegate void VertexAttrib2f(UInt32 index, Single v0, Single v1);

            internal static VertexAttrib2f glVertexAttrib2f;

            internal delegate void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1);

            internal static VertexAttrib2s glVertexAttrib2s;

            internal delegate void VertexAttrib2d(UInt32 index, Double v0, Double v1);

            internal static VertexAttrib2d glVertexAttrib2d;

            internal delegate void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1);

            internal static VertexAttribI2i glVertexAttribI2i;

            internal delegate void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1);

            internal static VertexAttribI2ui glVertexAttribI2ui;

            internal delegate void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2);

            internal static VertexAttrib3f glVertexAttrib3f;

            internal delegate void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2);

            internal static VertexAttrib3s glVertexAttrib3s;

            internal delegate void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2);

            internal static VertexAttrib3d glVertexAttrib3d;

            internal delegate void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2);

            internal static VertexAttribI3i glVertexAttribI3i;

            internal delegate void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2);

            internal static VertexAttribI3ui glVertexAttribI3ui;

            internal delegate void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3);

            internal static VertexAttrib4f glVertexAttrib4f;

            internal delegate void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3);

            internal static VertexAttrib4s glVertexAttrib4s;

            internal delegate void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);

            internal static VertexAttrib4d glVertexAttrib4d;

            internal delegate void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3);

            internal static VertexAttrib4Nub glVertexAttrib4Nub;

            internal delegate void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

            internal static VertexAttribI4i glVertexAttribI4i;

            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

            internal static VertexAttribI4ui glVertexAttribI4ui;

            internal delegate void VertexAttribL1d(UInt32 index, Double v0);

            internal static VertexAttribL1d glVertexAttribL1d;

            internal delegate void VertexAttribL2d(UInt32 index, Double v0, Double v1);

            internal static VertexAttribL2d glVertexAttribL2d;

            internal delegate void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2);

            internal static VertexAttribL3d glVertexAttribL3d;

            internal delegate void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);

            internal static VertexAttribL4d glVertexAttribL4d;

            internal delegate void VertexAttrib1fv(UInt32 index, Single[] v);

            internal static VertexAttrib1fv glVertexAttrib1fv;

            internal delegate void VertexAttrib1sv(UInt32 index, Int16[] v);

            internal static VertexAttrib1sv glVertexAttrib1sv;

            internal delegate void VertexAttrib1dv(UInt32 index, Double[] v);

            internal static VertexAttrib1dv glVertexAttrib1dv;

            internal delegate void VertexAttribI1iv(UInt32 index, Int32[] v);

            internal static VertexAttribI1iv glVertexAttribI1iv;

            internal delegate void VertexAttribI1uiv(UInt32 index, UInt32[] v);

            internal static VertexAttribI1uiv glVertexAttribI1uiv;

            internal delegate void VertexAttrib2fv(UInt32 index, Single[] v);

            internal static VertexAttrib2fv glVertexAttrib2fv;

            internal delegate void VertexAttrib2sv(UInt32 index, Int16[] v);

            internal static VertexAttrib2sv glVertexAttrib2sv;

            internal delegate void VertexAttrib2dv(UInt32 index, Double[] v);

            internal static VertexAttrib2dv glVertexAttrib2dv;

            internal delegate void VertexAttribI2iv(UInt32 index, Int32[] v);

            internal static VertexAttribI2iv glVertexAttribI2iv;

            internal delegate void VertexAttribI2uiv(UInt32 index, UInt32[] v);

            internal static VertexAttribI2uiv glVertexAttribI2uiv;

            internal delegate void VertexAttrib3fv(UInt32 index, Single[] v);

            internal static VertexAttrib3fv glVertexAttrib3fv;

            internal delegate void VertexAttrib3sv(UInt32 index, Int16[] v);

            internal static VertexAttrib3sv glVertexAttrib3sv;

            internal delegate void VertexAttrib3dv(UInt32 index, Double[] v);

            internal static VertexAttrib3dv glVertexAttrib3dv;

            internal delegate void VertexAttribI3iv(UInt32 index, Int32[] v);

            internal static VertexAttribI3iv glVertexAttribI3iv;

            internal delegate void VertexAttribI3uiv(UInt32 index, UInt32[] v);

            internal static VertexAttribI3uiv glVertexAttribI3uiv;

            internal delegate void VertexAttrib4fv(UInt32 index, Single[] v);

            internal static VertexAttrib4fv glVertexAttrib4fv;

            internal delegate void VertexAttrib4sv(UInt32 index, Int16[] v);

            internal static VertexAttrib4sv glVertexAttrib4sv;

            internal delegate void VertexAttrib4dv(UInt32 index, Double[] v);

            internal static VertexAttrib4dv glVertexAttrib4dv;

            internal delegate void VertexAttrib4iv(UInt32 index, Int32[] v);

            internal static VertexAttrib4iv glVertexAttrib4iv;

            internal delegate void VertexAttrib4bv(UInt32 index, SByte[] v);

            internal static VertexAttrib4bv glVertexAttrib4bv;

            internal delegate void VertexAttrib4ubv(UInt32 index, Byte[] v);

            internal static VertexAttrib4ubv glVertexAttrib4ubv;

            internal delegate void VertexAttrib4usv(UInt32 index, UInt16[] v);

            internal static VertexAttrib4usv glVertexAttrib4usv;

            internal delegate void VertexAttrib4uiv(UInt32 index, UInt32[] v);

            internal static VertexAttrib4uiv glVertexAttrib4uiv;

            internal delegate void VertexAttrib4Nbv(UInt32 index, SByte[] v);

            internal static VertexAttrib4Nbv glVertexAttrib4Nbv;

            internal delegate void VertexAttrib4Nsv(UInt32 index, Int16[] v);

            internal static VertexAttrib4Nsv glVertexAttrib4Nsv;

            internal delegate void VertexAttrib4Niv(UInt32 index, Int32[] v);

            internal static VertexAttrib4Niv glVertexAttrib4Niv;

            internal delegate void VertexAttrib4Nubv(UInt32 index, Byte[] v);

            internal static VertexAttrib4Nubv glVertexAttrib4Nubv;

            internal delegate void VertexAttrib4Nusv(UInt32 index, UInt16[] v);

            internal static VertexAttrib4Nusv glVertexAttrib4Nusv;

            internal delegate void VertexAttrib4Nuiv(UInt32 index, UInt32[] v);

            internal static VertexAttrib4Nuiv glVertexAttrib4Nuiv;

            internal delegate void VertexAttribI4bv(UInt32 index, SByte[] v);

            internal static VertexAttribI4bv glVertexAttribI4bv;

            internal delegate void VertexAttribI4ubv(UInt32 index, Byte[] v);

            internal static VertexAttribI4ubv glVertexAttribI4ubv;

            internal delegate void VertexAttribI4sv(UInt32 index, Int16[] v);

            internal static VertexAttribI4sv glVertexAttribI4sv;

            internal delegate void VertexAttribI4usv(UInt32 index, UInt16[] v);

            internal static VertexAttribI4usv glVertexAttribI4usv;

            internal delegate void VertexAttribI4iv(UInt32 index, Int32[] v);

            internal static VertexAttribI4iv glVertexAttribI4iv;

            internal delegate void VertexAttribI4uiv(UInt32 index, UInt32[] v);

            internal static VertexAttribI4uiv glVertexAttribI4uiv;

            internal delegate void VertexAttribL1dv(UInt32 index, Double[] v);

            internal static VertexAttribL1dv glVertexAttribL1dv;

            internal delegate void VertexAttribL2dv(UInt32 index, Double[] v);

            internal static VertexAttribL2dv glVertexAttribL2dv;

            internal delegate void VertexAttribL3dv(UInt32 index, Double[] v);

            internal static VertexAttribL3dv glVertexAttribL3dv;

            internal delegate void VertexAttribL4dv(UInt32 index, Double[] v);

            internal static VertexAttribL4dv glVertexAttribL4dv;

            internal delegate void VertexAttribP1ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            internal static VertexAttribP1ui glVertexAttribP1ui;

            internal delegate void VertexAttribP2ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            internal static VertexAttribP2ui glVertexAttribP2ui;

            internal delegate void VertexAttribP3ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            internal static VertexAttribP3ui glVertexAttribP3ui;

            internal delegate void VertexAttribP4ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);

            internal static VertexAttribP4ui glVertexAttribP4ui;

            internal delegate void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);

            internal static VertexAttribBinding glVertexAttribBinding;

            internal delegate void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

            internal static VertexArrayAttribBinding glVertexArrayAttribBinding;

            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);

            internal static VertexAttribDivisor glVertexAttribDivisor;

            internal delegate void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);

            internal static VertexAttribFormat glVertexAttribFormat;

            internal delegate void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            internal static VertexAttribIFormat glVertexAttribIFormat;

            internal delegate void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            internal static VertexAttribLFormat glVertexAttribLFormat;

            internal delegate void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);

            internal static VertexArrayAttribFormat glVertexArrayAttribFormat;

            internal delegate void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            internal static VertexArrayAttribIFormat glVertexArrayAttribIFormat;

            internal delegate void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);

            internal static VertexArrayAttribLFormat glVertexArrayAttribLFormat;

            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer);

            internal static VertexAttribPointer glVertexAttribPointer;

            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);

            internal static VertexAttribIPointer glVertexAttribIPointer;

            internal delegate void VertexAttribLPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);

            internal static VertexAttribLPointer glVertexAttribLPointer;

            internal delegate void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);

            internal static VertexBindingDivisor glVertexBindingDivisor;

            internal delegate void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

            internal static VertexArrayBindingDivisor glVertexArrayBindingDivisor;

            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);

            internal static Viewport glViewport;

            internal delegate void ViewportArrayv(UInt32 first, Int32 count, Single[] v);

            internal static ViewportArrayv glViewportArrayv;

            internal delegate void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);

            internal static ViewportIndexedf glViewportIndexedf;

            internal delegate void ViewportIndexedfv(UInt32 index, Single[] v);

            internal static ViewportIndexedfv glViewportIndexedfv;

            internal delegate void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

            internal static WaitSync glWaitSync;
        }
    }
}