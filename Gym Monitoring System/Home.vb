Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RichTextBox1.Text = "   
    UPPER BODY includes arms, shoulders and upper back. Some of the most common exercises for the upper body are biceps curls, triceps curls, bench presses, overhead presses, lateral raises, and upright rows.

    Why It’s Important: 
            Working the upper body tones the arms and helps you not only look good, but maintain upper body strength. As we get older–and I’m talking even past age 30–we slowly but surely start to lose muscle. Exercise is key to maintaining muscle mass as the years go by. Upper body workouts also work the shoulders and muscles of the upper back. This aids in keeping good posture as strong muscles help support the upper spine. Good posture allows your lungs and diaphragm to fully expand, aiding in respiratory health.
"
        RichTextBox2.Text = "
    CORE part includes your upper and lower abdominal muscles and back muscles. Some of the most common core exercises are sit-ups of various kinds, push-ups (men’s or women’s), leg raises, and planks. (Upper body workouts also help the core as your stomach muscles should be engaged as you lift.)

    Why It’s Important: 
            Your core supports your back, which in turn supports your entire body. Having strong stomach and back muscles helps take some of the load off of your spine. It helps improve balance, stability, and posture.
"
        RichTextBox3.Text = "
           LOWER BODY includes legs and glutes. Some of the most common exercises for the lower body are lunges, squats, step-ups, mountain climbers, and squat-thrusts.

        Why It’s Important: 
            Working the lower body tones the legs and glutes, and helps you maintain lower body strength. Powerful leg muscles allow us to climb stairs easily, to squat down and retrieve something off the floor, to get back up if we have fallen. Strong leg muscles also help protect our knees and hips from injury. They help us preserve our mobility, agility and stability as we age, and are helpful in maintaining our balance.
"

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
