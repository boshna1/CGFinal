Shader "Vertex Coloring Shader"
{
    Properties
    {
        _RedScale("Red", Range(0,255)) = 0
        _BlueScale("Blue", Range(0,255)) = 0
        _GreenScale("Green", Range(0,255)) = 0
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag

        #include "Lighting.cginc"

        struct appdata
        {
            float4 vertex : POSITION;
        };
        struct v2f
        {
            float4 vertex : SV_POSITION;
            float4 color : COLOR;
        };

        v2f vert (appdata v)
        {
            v2f o;
            UNITY_INITIALIZE_OUTPUT(v2f,o)
            o.vertex = UnityObjectToClipPos(v.vertex);
            return o;
        }

        float _RedScale;
        float _BlueScale;
        float _GreenScale;
        fixed4 frag (v2f i) : SV_Target
        {
            
            fixed4 col = i.color;
            _RedScale *=  _Time.y;
            _GreenScale *= _Time.y * 0.5;
            _BlueScale *= _Time.y * 0.25;
            col.r = i.vertex.x / _RedScale;
            col.g = i.vertex.y / _GreenScale;
            col.b = i.vertex.z / _BlueScale;
            return col;
        }
        ENDCG
        }
        
    }
 }