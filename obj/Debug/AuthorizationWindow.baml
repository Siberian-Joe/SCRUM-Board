   M S B A M L   `   `   `  ����N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  5   	   -    'ScrumBoardNewDesign.AuthorizationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ScrumBoardNewDesign     5   	   -   5          � Title$  SCRUM board��5   	   $	��450��6   $	��380��6*    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5       �� Color$ #101828��6'   5      �� 5      -   5         ��Name$ 
exitButton��5      $��23��6)   $��23��64   $��×��6@   $��0, 15, 15, 0q�6f   $��Normal"�6|   $	��Top=�6�   $��Right=�6�   $��16(�6�   �� 5      $��Center=�6   .+�5      �� $��assets/Sign-In-icon.png��6   $��80��69    �� BitmapScalingMode$ HighQuality=�6D   �� 5      -   5        	 ��Name$	 	textBlock��5      $��Sign In��6/   $��Light"�6>   $��	helvetica)�6Q   $��22(�6h   
�������$��Center=�6�   5      �� 5      -   5        
 ��Name$
 authorizationWindow��5      $��1��66   $��Center=�6C   $y�Visible=�6`   .+�5       ��  �� Orientation$ 
Horizontal=�6   .+�5!      �� -   5         ��Name$ usernameTextBox��5!      $��	Helvetica)�67   $��Light"�6N   $��Username��6a   $��20(�6q   $��Center=�6   
�������
������ $	��235��6�    J� Opacity$	 0.5Q�6�   
������ 6  �� 5"      $��assets/Sign-In-icon.png��6   $��26��6=   $ HighQuality=�6H   5#      �� 5$      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 5&      $ 
Horizontal=�6   $��0, 20, 0, 0q�66   .+�5'      G� -   5         G�Name$ passwordTextBox��5'   "   $��	Helvetica)�6;   $��Light"�6R    G� Password$ Password��6e   $��20(�6y   $��Center=�6�   
�������
������ $	��235��6�   $	 0.5Q�6�   
������ 6$  �� 5(      $��assets/key.png��6   $��26��64   $ HighQuality=�6?   5)      �� 5*      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 5,      $ 
Horizontal=�6   $��0, 50, 0, 0q�67   $��Center=�6L   .+�5-      �� -   5        $ signInButton��5-      $	��100��63   $��40��6?   $��Sign In��6K   $��0, 0, 10, 0q�6]   6r   �� 5.      -   5        $ signUpButton��5.      $	��100��63   $��40��6?   $��Sign Up��6K   $��10, 0, 0, 0q�6]   6r   5/      50      �� 52      -	   5        $
 registrationWindow��52      $��1��65   $��Center=�6B   $y�	Collapsed=�6_   .+�53      �� $ 
Horizontal=�6   .+�54      �� -
   5        $! registrationUsernameTextBox��54      $��	Helvetica)�6C   $��Light"�6Z   $��Username��6m   $��20(�6}   $��Center=�6�   
�������
������ $	��235��6�   $	 0.5Q�6�   
������ 6$  �� 55      $��assets/Sign-In-icon.png��6   $��26��6=   $ HighQuality=�6H   56      �� 57      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 59      $ 
Horizontal=�6   $��0, 20, 0, 0q�66   .+�5:      �� -   5        $! registrationFullNameTextBox��5:      $��	Helvetica)�6C   $��Light"�6Z   $��	Full Name��6m   $��20(�6~   $��Center=�6�   
�������
������ $	��235��6�   $	 0.5Q�6�   
������ 69  �� 5;      $��assets/name.png��6   $��26��65   $ HighQuality=�6@   5<      �� 5=      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 5?      $ 
Horizontal=�6   $��0, 20, 0, 0q�66   .+�5@      G� -   5        $&  registrationFirstPasswordTextBox��5@   "   $��	Helvetica)�6L   $��Light"�6c   $ Password��6v   $��20(�6�   $��Center=�6�   
�������
������ $	��235��6�   $	 0.5Q�6�   
������ 65  �� 5A      $��assets/key.png��6   $��26��64   $ HighQuality=�6?   5B      �� 5C      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 5E      $ 
Horizontal=�6   $��0, 20, 0, 0q�66   .+�5F      G� -   5        $' !registrationSecondPasswordTextBox��5F   "   $��	Helvetica)�6M   $��Light"�6d   $ Password��6w   $��20(�6�   $��Center=�6�   
�������
������ $	��235��6�   $	 0.5Q�6�   
������ 66  �� 5G      $��assets/key.png��6   $��26��64   $ HighQuality=�6?   5H      �� 5I      $	��261��6   $��2��6%   
�������$	 0.5Q�6C   �� 5K      $ 
Horizontal=�6   $��
0, 7, 0, 0q�67   $��Center=�6K   .+�5L      �� -   5        $ continueButton��5L      $	��100��65   $��40��6A   $��Continue��6M   $��0, 0, 10, 0q�6`   6u   �� 5M      -   5        $ 
backButton��5M      $	��100��61   $��40��6=   $
��Back��6I   $��10, 0, 0, 0q�6X   6m   5N      5O      5P      5Q      5R      