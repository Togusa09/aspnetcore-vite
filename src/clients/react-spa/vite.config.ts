import { defineConfig } from "vite"
import checker from "vite-plugin-checker";
import react from "@vitejs/plugin-react"

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    react(),
    checker({ typescript: { tsconfigPath: "tsconfig.app.json" }}),
  ],
  appType: 'custom',
  //root: 'src',
  publicDir: 'public',
  build: {
      manifest: true,
      emptyOutDir: true,
      outDir: '../../WebApp/wwwroot',
      //assetsDir: '',
      rollupOptions: {
          input: 'src/main.tsx'
      },
  }
})
