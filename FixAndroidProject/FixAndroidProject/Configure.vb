Imports System.Text.Encoding

Module Configure

    Public pathGradle As String = ""

    Sub configureProject(ByVal package As String, ByVal useGoogleRepos As Boolean)
        If My.Computer.FileSystem.DirectoryExists("app\src\androidTest") Then My.Computer.FileSystem.DeleteDirectory("app\src\androidTest", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        If My.Computer.FileSystem.DirectoryExists("app\src\test") Then My.Computer.FileSystem.DeleteDirectory("app\src\test", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        If My.Computer.FileSystem.DirectoryExists("app\src\main\java") Then My.Computer.FileSystem.DeleteDirectory("app\src\main\java", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        configureBuildGradle(useGoogleRepos)
        configureAppBuildGradle(package)
        configureAndroidManifest(package)
        configureMainClass(package)
        configureGradleWrapper()
    End Sub

    Private Sub configureBuildGradle(ByVal useGR As Boolean)
        write("build.gradle", "buildscript {", False)
        write("build.gradle", "    ext.kotlin_version = '1.4.20'")
        write("build.gradle", "    repositories {")
        write("build.gradle", "        maven { url 'https://jitpack.io' }" & vbCrLf)
        If useGR Then
            write("build.gradle", "        google()")
        End If
        write("build.gradle", "        mavenCentral()")
        write("build.gradle", "        jcenter()" & vbCrLf)
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/google'}")
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/central'}")
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/jcenter'}" & vbCrLf)
        write("build.gradle", "        maven { url 'https://maven.google.com' }")
        write("build.gradle", "    }" & vbCrLf)

        write("build.gradle", "    dependencies {")
        write("build.gradle", "        classpath 'com.android.tools.build:gradle:4.0.0'")
        write("build.gradle", "        classpath 'org.jetbrains.kotlin:kotlin-gradle-plugin:' + kotlin_version")
        write("build.gradle", "    }")
        write("build.gradle", "}" & vbCrLf)

        write("build.gradle", "allprojects {")
        write("build.gradle", "    repositories {")
        write("build.gradle", "        maven { url 'https://jitpack.io' }" & vbCrLf)
        If useGR Then
            write("build.gradle", "        google()")
        End If
        write("build.gradle", "        mavenCentral()")
        write("build.gradle", "        jcenter()" & vbCrLf)
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/google'}")
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/central'}")
        write("build.gradle", "        maven { url 'https://maven.aliyun.com/repository/jcenter'}" & vbCrLf)
        write("build.gradle", "        maven { url 'https://maven.google.com' }")
        write("build.gradle", "    }")
        write("build.gradle", "}" & vbCrLf)

        write("build.gradle", "task clean(type: Delete) {")
        write("build.gradle", "    delete rootProject.buildDir")
        write("build.gradle", "}")
    End Sub

    Private Sub configureAppBuildGradle(ByVal package As String)
        My.Computer.FileSystem.CreateDirectory("app")
        write("app\build.gradle", "apply plugin: 'com.android.application'", False)
        write("app\build.gradle", "apply plugin: 'kotlin-android'")
        write("app\build.gradle", "apply plugin: 'kotlin-android-extensions'" & vbCrLf)

        write("app\build.gradle", "android {")
        write("app\build.gradle", "    compileSdkVersion 29" & vbCrLf)

        write("app\build.gradle", "    defaultConfig {")
        write("app\build.gradle", "        applicationId '" & package & "'")
        write("app\build.gradle", "        minSdkVersion 16")
        write("app\build.gradle", "        targetSdkVersion 29")
        write("app\build.gradle", "        versionCode 1")
        write("app\build.gradle", "        versionName '1.0'")
        write("app\build.gradle", "        vectorDrawables.useSupportLibrary = true")
        write("app\build.gradle", "    }" & vbCrLf)

        write("app\build.gradle", "    buildTypes {")
        write("app\build.gradle", "        release {")
        write("app\build.gradle", "            minifyEnabled false")
        write("app\build.gradle", "            proguardFiles getDefaultProguardFile('proguard-android-optimize.txt'), 'proguard-rules.pro'")
        write("app\build.gradle", "        }")
        write("app\build.gradle", "    }")
        write("app\build.gradle", "}")

        write("app\build.gradle", "dependencies {")
        write("app\build.gradle", "    implementation fileTree(dir: 'libs', include: ['*.jar'])")
        write("app\build.gradle", "    implementation 'org.jetbrains.kotlin:kotlin-stdlib:' + kotlin_version")
        write("app\build.gradle", "    implementation 'androidx.core:core-ktx:1.3.2'")
        write("app\build.gradle", "    implementation 'androidx.appcompat:appcompat:1.2.0'")
        write("app\build.gradle", "    implementation 'androidx.constraintlayout:constraintlayout:2.0.4'")
        write("app\build.gradle", "    implementation 'androidx.recyclerview:recyclerview:1.1.0'")
        write("app\build.gradle", "    implementation 'com.google.android.material:material:1.2.1'")
        write("app\build.gradle", "    implementation 'androidx.legacy:legacy-support-v4:1.0.0'")
        write("app\build.gradle", "    implementation 'androidx.viewpager2:viewpager2:1.0.0'")
        write("app\build.gradle", "    implementation 'androidx.cardview:cardview:1.0.0'")
        write("app\build.gradle", "    implementation 'androidx.gridlayout:gridlayout:1.0.0'")
        write("app\build.gradle", "}")
    End Sub

    Private Sub configureAndroidManifest(ByVal package As String)
        My.Computer.FileSystem.CreateDirectory("app\src\main")
        write("app\src\main\AndroidManifest.xml", "<?xml version=""1.0"" encoding=""utf-8""?>", False)
        write("app\src\main\AndroidManifest.xml", "<manifest xmlns:android=""http://schemas.android.com/apk/res/android""")
        write("app\src\main\AndroidManifest.xml", "    package=""" & package & """>" & vbCrLf)

        write("app\src\main\AndroidManifest.xml", "    <application")
        write("app\src\main\AndroidManifest.xml", "        android:allowBackup=""true""")
        write("app\src\main\AndroidManifest.xml", "        android:icon=""@mipmap/ic_launcher""")
        write("app\src\main\AndroidManifest.xml", "        android:label=""@string/app_name""")
        write("app\src\main\AndroidManifest.xml", "        android:roundIcon=""@mipmap/ic_launcher_round""")
        write("app\src\main\AndroidManifest.xml", "        android:supportsRtl=""true""")
        write("app\src\main\AndroidManifest.xml", "        android:theme=""@style/AppTheme"">")
        write("app\src\main\AndroidManifest.xml", "        <activity android:name=""" & package & ".MainActivity"">")
        write("app\src\main\AndroidManifest.xml", "            <intent-filter>")
        write("app\src\main\AndroidManifest.xml", "                <action android:name=""android.intent.action.MAIN"" />" & vbCrLf)

        write("app\src\main\AndroidManifest.xml", "                <category android:name=""android.intent.category.LAUNCHER"" />")
        write("app\src\main\AndroidManifest.xml", "            </intent-filter>")
        write("app\src\main\AndroidManifest.xml", "        </activity>")
        write("app\src\main\AndroidManifest.xml", "    </application>" & vbCrLf)

        write("app\src\main\AndroidManifest.xml", "</manifest>")
    End Sub

    Private Sub configureMainClass(ByVal package As String)
        Dim folders As String() = package.Split(".")
        Dim path As String = "app\src\main\java\"

        For Each folder As String In folders
            path = path & folder & "\"
        Next

        My.Computer.FileSystem.CreateDirectory(path)

        write(path & "MainActivity.kt", "package " & package & vbCrLf, False)

        write(path & "MainActivity.kt", "import androidx.appcompat.app.AppCompatActivity")
        write(path & "MainActivity.kt", "import android.os.Bundle" & vbCrLf)

        write(path & "MainActivity.kt", "class MainActivity : AppCompatActivity() {")
        write(path & "MainActivity.kt", "    override fun onCreate(savedInstanceState: Bundle?) {")
        write(path & "MainActivity.kt", "        super.onCreate(savedInstanceState)")
        write(path & "MainActivity.kt", "        setContentView(R.layout.activity_main)")
        write(path & "MainActivity.kt", "    }")
        write(path & "MainActivity.kt", "}" & vbCrLf)
    End Sub

    Private Sub configureGradleWrapper()
        My.Computer.FileSystem.CreateDirectory("gradle\wrapper")
        write("gradle\wrapper\gradle-wrapper.properties", "distributionBase=GRADLE_USER_HOME", False)
        write("gradle\wrapper\gradle-wrapper.properties", "distributionPath=wrapper/dists")
        write("gradle\wrapper\gradle-wrapper.properties", "zipStoreBase=GRADLE_USER_HOME")
        write("gradle\wrapper\gradle-wrapper.properties", "zipStorePath=wrapper/dists")
        write("gradle\wrapper\gradle-wrapper.properties", "distributionUrl=file\:/" & pathGradle.Replace("\", "/"))
    End Sub

    Private Sub write(ByVal fn As String, ByVal text As String, Optional ByVal append As Boolean = True)
        My.Computer.FileSystem.WriteAllText(fn, text & vbCrLf, append, System.Text.Encoding.Default)
    End Sub

End Module
