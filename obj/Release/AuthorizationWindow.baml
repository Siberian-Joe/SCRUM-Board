   M S B A M L   `   `   `  ���� N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  -    'ScrumBoardNewDesign.AuthorizationWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:ScrumBoardNewDesign     -     � Title$  
MainWindow��$	��450��$	��380�� � AllowsTransparency . 
������  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.��� .+��  � RowDefinitions �� �� .+���  �� CornerRadius$ 10��$��2������ .���  � Color$ #7be9f6�� � Offset$	 0.0Q�� $ #f083da��$ 1Q��� -    ��Name$ 
exitButton��$��23��$��23��$��×��$��0, 15, 15, 0q�$��Normal"�$	��Top=�$��Right=�$��16(��� $��Center=�.+��� $��assets/Sign-In-icon.png��$��80��	 �� BitmapScalingMode$	 HighQuality=��� $��Sign In��$��Light"�$��	helvetica)�$��22(�
�������$��Center=��� $��1��$��Center=�.+��� 
 �� Orientation$
 
Horizontal=�.+��� -    ��Name$ usernameTextBox��$��	Helvetica)�$��Light"�$��Username��$��20(�$��Center=�
�������
������ $	��235�� J� Opacity$	 0.5Q�
������ �� $	��250��$��2��
�������$	 0.5Q��� $
 
Horizontal=�$��0, 20, 0, 0q�.+�G� -    G�Name$ passwordTextBox��$��	Helvetica)�$��Light"� G� Password$ Password��$��20(�$��Center=�
�������
������ $	��235��$	 0.5Q�
������ �� $	��250��$��2��
�������$	 0.5Q��� $
 
Horizontal=�$��0, 50, 0, 0q�$��Center=�.+��� -   $ signInButton��$	��100��$��40��$��Sign In��$��0, 0, 10, 0q��� -   $ signUpButton��$	��100��$��40��$��Sign Up��$��10, 0, 0, 0q�